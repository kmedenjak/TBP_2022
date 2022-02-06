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
    public partial class FrmPocetnaForma : Form
    {
        Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        public FrmPocetnaForma()
        {
            InitializeComponent();
            PopisZaposlenika();
        }

        private void btn_UnosZaposlenika_Click(object sender, EventArgs e)
        {
            Form UnosKorisnika = new FrmUnosKorisnika();
            UnosKorisnika.ShowDialog();
            PopisZaposlenika();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form Meni = new FrmMenu();
            Meni.Show();
        }

        private void btn_ObrsiZaposlenika_Click(object sender, EventArgs e)
        {
            Korisnik.ObrisiKorisnika(dgv_popisZaposlenika.CurrentRow.Cells["OIB"].Value.ToString());
            PopisZaposlenika();
        }

        private void PopisZaposlenika()
        {
            Korisnik.OsvjeziListu();
            dgv_popisZaposlenika.DataSource = Korisnik.korisnici;
        }

        private void btnPrikazPlatneListe_Click(object sender, EventArgs e)
        {
            Form PlatneListe = new frmPopisPlatnihListi();
            PlatneListe.ShowDialog();
        }

        private void btn_GenerirajPlatnuListu_Click(object sender, EventArgs e)
        {
            PlatnaLista.GenerirajPlatnuListu(dgv_popisZaposlenika.CurrentRow.Cells["OIB"].Value.ToString());
            MessageBox.Show("Generirana je platna lista!");
        }
    }
}
