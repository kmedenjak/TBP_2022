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
            dgv_popisZaposlenika.DataSource = Korisnik.korisnici;
        }

        private void btn_UnosZaposlenika_Click(object sender, EventArgs e)
        {
            Form UnosKorisnika = new FrmUnosKorisnika();
            UnosKorisnika.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form Meni = new FrmMenu();
            Meni.Show();
        }
    }
}
