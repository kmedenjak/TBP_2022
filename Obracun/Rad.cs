using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obracun
{
    internal class Rad
    {
        public int ID { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }

        public void Zapocni(DateTime pocetak)
        {
            this.Pocetak = pocetak;
        }
        public void Zavrsi(DateTime kraj)
        {
            this.Kraj = kraj;
        }
    }
}
