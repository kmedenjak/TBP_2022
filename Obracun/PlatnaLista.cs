using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracun
{
    public class PlatnaLista
    {
        static Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        public string ID { get; set; }
        public int BrojRadnihDana { get; set; }
        public double UkupniIznos { get; set; }
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public static List<PlatnaLista> DohvatiPlatneListe()
        {
            List<PlatnaLista> platneListe = (from DataRow dr in baza.DohvatiRezultat("select pl.platna_lista_id, pl.broj_radnih_dana, " +
                                             "pl.ukupni_iznos, pl.korisnik_id, k.ime, k.prezime from platna_lista pl, korisnik k where k.oib = pl.korisnik_id").Rows
                                        select new PlatnaLista()
                                        {
                                            ID = dr["platna_lista_id"].ToString(),
                                            BrojRadnihDana = int.Parse(dr["broj_radnih_dana"].ToString()),
                                            UkupniIznos = double.Parse(dr["ukupni_iznos"].ToString()),
                                            OIB = dr["korisnik_id"].ToString(),
                                            Ime = dr["ime"].ToString(),
                                            Prezime = dr["prezime"].ToString()
                                        }).ToList();
            return platneListe;
        }

        public static void GenerirajPlatnuListu(string korisnikId) 
        {
            string upit = "insert into platna_lista (broj_radnih_dana, ukupni_iznos, korisnik_id) " +
                "values((select count(date(r.radio_do) - date(r.radio_od)) " +
                "from korisnik k, rad r, radno_mjesto rm, dnevnica d " +
                "where rm.radno_mjesto_id = k.radno_mjesto_id and d.korisnik_id = k.oib and r.rad_id = d.rad_id " +
                $"and k.oib = '{korisnikId}' and extract(month from r.radio_do)::integer = extract(month from current_timestamp)::integer)," +
                "(select sum(\"iznosDnevnice\") " +
                "from korisnik k, rad r, radno_mjesto rm, dnevnica d " +
                $"where rm.radno_mjesto_id = k.radno_mjesto_id and d.korisnik_id = k.oib and r.rad_id = d.rad_id and k.oib = '{korisnikId}' " +
                $"and extract(month from r.radio_do)::integer = extract(month from current_timestamp)::integer), '{korisnikId}'); ";
            baza.Upis(upit);
        }
    }
}
