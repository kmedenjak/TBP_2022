using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracun
{
    internal class Korisnik
    {
        static Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        public static List<Korisnik> korisnici = (from DataRow dr in baza.DohvatiRezultat("select * from korisnik").Rows
                                                  select new Korisnik()
                                                  {
                                                      OIB = dr["oib"].ToString(),
                                                      ID = dr["id_prijave"].ToString(),
                                                      Ime = dr["ime"].ToString(),
                                                      Prezime = dr["prezime"].ToString(),
                                                      Prijavljen = Convert.ToBoolean(dr["prijavljen"]),
                                                      Uloga = (int)dr["uloga_id"]
                                                  }).ToList();
        public string OIB { get; set; }
        public string ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Prijavljen { get; set; }
        public int Uloga { get; set; }

        public Rad rad = new Rad();

        public void Prijava(string id)
        {
            rad.Zapocni(DateTime.Now);
            if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                rad.ID = int.Parse(baza.UpisSVracanjem($"insert into rad (radio_od, ned_blagdan) values('{rad.Pocetak}', true) returning rad_id;"));
            }
            else
            {
                rad.ID = int.Parse(baza.UpisSVracanjem($"insert into rad (radio_od, ned_blagdan) values('{rad.Pocetak}', false) returning rad_id;"));
            }
            baza.Upis($"update korisnik set prijavljen = true where id_prijave = '{id}'");
            Prijavljen = true;
        }

        public void Odjava(string id)
        {
            rad.Zavrsi(DateTime.Now);
            //rad.Zavrsi(DateTime.Now.AddMinutes(10));
            //rad.Zavrsi(DateTime.Now.AddHours(1));
            baza.Upis($"update korisnik set prijavljen = false where id_prijave = '{id}'");
            baza.Upis($"update rad set radio_do = '{rad.Kraj}' where rad_id = '{rad.ID}';");
            baza.Upis($"insert into dnevnica (rad_id, korisnik_id) values({rad.ID}, '{OIB}')");
            baza.IzracunSatnice();
            Prijavljen = false;
        }

        public static void ObrisiKorisnika(string oib)
        {
            string brisanjeKorisnika = $"DELETE FROM korisnik WHERE oib = '{oib}'";
            baza.Upis(brisanjeKorisnika);
        }

        public static List<Korisnik> DohvatiKorisnike()
        {
            korisnici = (from DataRow dr in baza.DohvatiRezultat("select * from korisnik").Rows
                                                      select new Korisnik()
                                                      {
                                                          OIB = dr["oib"].ToString(),
                                                          ID = dr["id_prijave"].ToString(),
                                                          Ime = dr["ime"].ToString(),
                                                          Prezime = dr["prezime"].ToString(),
                                                          Prijavljen = Convert.ToBoolean(dr["prijavljen"]),
                                                          Uloga = (int)dr["uloga_id"],
                                                      }).ToList();
            return korisnici;
        }
    }
}
