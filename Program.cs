using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabung tb = new Tabung();
            Console.Write("Masukkan Jari-Jari : ");
            tb.SetJari(double.Parse(Console.ReadLine()));
            Console.Write("Masukkan Tinggi : ");
            tb.SetTinggi(double.Parse(Console.ReadLine()));
            Console.WriteLine("Luas Lingkaran : " + tb.LuasLingkaran());
            Console.WriteLine("Volume Tabung : " + tb.VolumTabung());
            Console.ReadLine();
        }
    }
}
