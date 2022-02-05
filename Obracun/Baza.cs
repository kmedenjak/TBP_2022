using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracun
{
    internal class Baza
    {
        public NpgsqlConnection Connection { get; set; }

        public Baza(NpgsqlConnection connection)
        {
            this.Connection = connection;
        }

        public DataTable DohvatiRezultat(string upit)
        {
            DataTable dt = new DataTable();
            if (Connection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Connection.Open();
                NpgsqlCommand sql = new NpgsqlCommand();
                sql.Connection = Connection;
                sql.CommandType = CommandType.Text;
                sql.CommandText = upit;
                NpgsqlDataReader reader = sql.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                sql.Dispose();
                Connection.Close();
                return dt;
            }
        }

        public void Upis(string upit)
        {
            if (Connection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Connection.Open();
                NpgsqlCommand sql = new NpgsqlCommand();
                sql.Connection = Connection;
                sql.CommandType = CommandType.Text;
                sql.CommandText = upit;
                sql.ExecuteNonQuery();
                sql.Dispose();
                Connection.Close();
            }
        }

        public string UpisSVracanjem(string upit)
        {
            string rez;
            if (Connection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Connection.Open();
                NpgsqlCommand sql = new NpgsqlCommand();
                sql.Connection = Connection;
                sql.CommandType = CommandType.Text;
                sql.CommandText = upit;
                rez = sql.ExecuteScalar().ToString();
                sql.Dispose();
                Connection.Close();
                return rez;
            }
        }

        public void IzracunSatnice()
        {
            if (Connection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Connection.Open();
                NpgsqlCommand sql = new NpgsqlCommand();
                sql.Connection = Connection;
                sql.CommandType = CommandType.Text;
                sql.CommandText = "SELECT izracun_satnice()";
                sql.ExecuteNonQuery();
                sql.Dispose();
                Connection.Close();
            }
        }
    }
}
