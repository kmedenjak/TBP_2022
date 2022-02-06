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
    public partial class FrmUnosKorisnika : Form
    {
        Baza baza = new Baza(new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=TBP2021"));
        public FrmUnosKorisnika()
        {
            InitializeComponent();
            dgv_RadnoMjesto.DataSource = RadnoMjesto.DohvatiRadnaMjesta();

        }

        private void btn_Odustani_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_Unesi_Click(object sender, EventArgs e)
        {
            int idRadnogMjesta = int.Parse(dgv_RadnoMjesto.CurrentRow.Cells[0].Value.ToString());
            baza.Upis($"INSERT INTO korisnik (oib, ime, prezime, telefon, email, id_prijave, uloga_id, radno_mjesto_id, nadredeni, prijavljen) VALUES ('{txt_Oib.Text}', '{txt_Ime.Text}', '{txt_Prezime.Text}', '{txt_Telefon.Text}', '{txt_Email.Text}', '{txt_ID.Text}', 3, {idRadnogMjesta}, null, false)");
        }
    }
}
