using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obracun
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            NpgsqlConnection baza = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021");
            baza.Open();
            NpgsqlCommand sql = new NpgsqlCommand();
            sql.Connection = baza;
            sql.CommandType = CommandType.Text;
            sql.CommandText = "select radno_mjesto_id, naziv, satnica from radno_mjesto";
            NpgsqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv_PopisRadnoMjesto.DataSource = dt;
            }

            NpgsqlCommand sql2 = new NpgsqlCommand();
            sql2.Connection = baza;
            sql2.CommandType = CommandType.Text;
            sql2.CommandText = "select * from odjel";
            NpgsqlDataReader reader2 = sql2.ExecuteReader();

            if (reader2.HasRows)
            {
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);
                dgv_PopisOdjel.DataSource = dt2;   
            }

            sql.Dispose();
            baza.Close();
        }

        private void btn_Zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
