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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btn_Prijava_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = Korisnik.korisnici.FirstOrDefault(k => k.ID == txt_PrijavaId.Text);
            if (korisnik != null && !korisnik.Prijavljen)
            {
                MessageBox.Show("Uspjesna prijava");
                korisnik.Prijava(txt_PrijavaId.Text);
                txt_PrijavaId.Clear();
            }
            else if (korisnik.Prijavljen)
            {
                korisnik.Odjava(txt_PrijavaId.Text);
                MessageBox.Show("Uspjesna odjava");
                txt_PrijavaId.Clear();
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik s tim ID-em");
            }
        }

        private void txt_PrijavaId_TextChanged(object sender, EventArgs e)
        {
            Korisnik korisnik = Korisnik.korisnici.FirstOrDefault(k => k.ID == txt_PrijavaId.Text);
            if(korisnik != null && txt_PrijavaId.Text == korisnik.ID && korisnik.Prijavljen)
            {
                btn_Prijava.Text = "Odjava";
            }
            else
            {
                btn_Prijava.Text = "Prijava";
            }
        }

        private void btn_Pocetna_Click(object sender, EventArgs e)
        {
            Form pocetna = new FrmPocetnaForma();
            pocetna.ShowDialog();
        }
    }
}
