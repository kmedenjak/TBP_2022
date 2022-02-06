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
        Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        public FrmMenu()
        {
            InitializeComponent();


            PopisRadnihMjesta();
            PopisOdjela();

            string upitOdjel = "select naziv_odjela from odjel";
            for (int i = 0; i < baza.DohvatiRezultat(upitOdjel).Rows.Count; i++)
            {
                cmb_Odjel.Items.Add(baza.DohvatiRezultat(upitOdjel).Rows[i].ItemArray[0].ToString());
            }
            baza.Connection.Close();

            string upitVoditelj = "select concat(k.ime, ' ',  k.prezime) " +
                "from korisnik k, radno_mjesto rm where rm.radno_mjesto_id = k.radno_mjesto_id and rm.naziv = 'Voditelj odjela'";

            for (int i = 0; i < baza.DohvatiRezultat(upitVoditelj).Rows.Count; i++)
            {
                cmb_VoditeljOdjela.Items.Add(baza.DohvatiRezultat(upitVoditelj).Rows[i].ItemArray[0].ToString());
            }
            baza.Connection.Close();


        }

        private void PopisRadnihMjesta()
        {
            dgv_PopisRadnoMjesto.DataSource = RadnoMjesto.DohvatiRadnaMjesta();
        }

        private void btn_Zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UnesiOdjel_Click(object sender, EventArgs e)
        {
            Odjel.UnosOdjela(txt_NazivOdjel.Text, cmb_VoditeljOdjela.SelectedItem.ToString());
            PopisOdjela();
        }

        public void PopisOdjela()
        {
            dgv_PopisOdjel.DataSource = Odjel.DohvatiOdjele();
        }

        private void btn_ObrisiOdjel_Click(object sender, EventArgs e)
        {
            Odjel.ObrisiOdjel(dgv_PopisOdjel.CurrentRow.Cells["Naziv"].Value.ToString());
            PopisOdjela();
        }

        private void btn_UnesiRadnoMjesto_Click(object sender, EventArgs e)
        {
            RadnoMjesto.UnosRadnogMjesta(txt_NazivRadnoMjesto.Text, Convert.ToDouble(txt_Satnica.Text), Odjel.DohvatiId(cmb_Odjel.SelectedItem.ToString()));
            PopisRadnihMjesta();
        }

        private void btn_ObrisiRadnoMjesto_Click(object sender, EventArgs e)
        {
            RadnoMjesto.ObrisiRadnoMjesto(dgv_PopisRadnoMjesto.CurrentRow.Cells["Naziv"].Value.ToString());
            PopisRadnihMjesta();
        }
    }
}
