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
    public partial class frmPopisPlatnihListi : Form
    {
        public frmPopisPlatnihListi()
        {
            InitializeComponent();
            PopisPlatnihListi();
        }

        public void PopisPlatnihListi()
        {
            dgvPopisPlatnihListi.DataSource = PlatnaLista.DohvatiPlatneListe();
        }
    }
}
