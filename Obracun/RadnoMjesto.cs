using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracun
{
    internal class RadnoMjesto
    {
        static Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        
        public string ID { get; set; }
        public string Naziv { get; set; }

        public static List<RadnoMjesto> DohvatiRadnaMjesta()
        {
            List<RadnoMjesto> radnaMjesta = (from DataRow dr in baza.DohvatiRezultat("select * from radno_mjesto").Rows
                                                           select new RadnoMjesto()
                                                           {
                                                               ID = dr["radno_mjesto_id"].ToString(),
                                                               Naziv = dr["naziv"].ToString()
                                                           }).ToList();
            return radnaMjesta;
        }

        public static void UnosRadnogMjesta(string naziv, double satnica, int odjelId)
        {
            string unosRadnogMjesta = $"INSERT INTO radno_mjesto (radno_mjesto_id, naziv, satnica, odjel_id) VALUES (DEFAULT, '{naziv}', {satnica}, {odjelId})";
            baza.Upis(unosRadnogMjesta);
        }

        public static void ObrisiRadnoMjesto(string naziv)
        {
            string brisanjeRadnogMjesta = $"DELETE FROM radno_mjesto WHERE naziv = '{naziv}'";
            baza.Upis(brisanjeRadnogMjesta);
        }
    }
}
