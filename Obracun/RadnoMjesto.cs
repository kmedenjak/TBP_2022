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
        public static List<RadnoMjesto> radnaMjesta = (from DataRow dr in baza.DohvatiRezultat("select * from radno_mjesto").Rows
                                                  select new RadnoMjesto()
                                                  {
                                                      ID = dr["radno_mjesto_id"].ToString(),
                                                      Naziv = dr["naziv"].ToString()
                                                  }).ToList();
        public string ID { get; set; }
        public string Naziv { get; set; }
    }
}
