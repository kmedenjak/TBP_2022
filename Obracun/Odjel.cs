using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Obracun
{
    internal class Odjel
    {
        static Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));

        public string ID { get; set; }
        public string Naziv { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }

        public static int DohvatiId(string naziv)
        {
            string dohvatiId = $"select odjel_id from odjel where naziv_odjela = '{naziv}'";
            return Convert.ToInt32(baza.DohvatiRezultat(dohvatiId).Rows[0].ItemArray[0].ToString());
        }

        public static void UnosOdjela(string naziv, string voditelj)
        {
            string unosOdjela = "insert into odjel (naziv_odjela, voditelj_odjela) values('" + naziv + "'," +
                "(select k.id_prijave from korisnik k where concat(k.ime, ' ', k.prezime) = '" + voditelj + "'))";
            baza.Upis(unosOdjela);
        }

        public static void ObrisiOdjel(string naziv)
        {
            string brisanjeOdjela = $"DELETE FROM odjel WHERE naziv_odjela = '{naziv}'";
            baza.Upis(brisanjeOdjela);
        }

        public static List<Odjel> DohvatiOdjele()
        {
            List<Odjel> odjeli = (from DataRow dr in baza.DohvatiRezultat("select o.odjel_id, o.naziv_odjela, k.ime, k.prezime from korisnik k, odjel o where k.id_prijave = o.voditelj_odjela").Rows
                                                select new Odjel()
                                                {
                                                    ID = dr["odjel_id"].ToString(),
                                                    Naziv = dr["naziv_odjela"].ToString(),
                                                    Prezime = dr["prezime"].ToString(),
                                                    Ime = dr["ime"].ToString()
                                                }).ToList();
            return odjeli;
        }

    }
}
