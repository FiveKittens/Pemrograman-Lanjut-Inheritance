using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Tabung : Lingkaran
    {
        private double tinggi;

        public void SetTinggi(double tinggi)
        {
            this.tinggi = tinggi;
        }
        public double VolumTabung()
        {
            return (LuasLingkaran() * tinggi);
        }
    }
}
