using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Lingkaran
    {
        private double jari;
        public const double phi = 3.14;

        public void SetJari(double jari)
        {
            this.jari = jari;
        }
        public double LuasLingkaran()
        {
            return (phi * jari * jari);
        }
    }
}
