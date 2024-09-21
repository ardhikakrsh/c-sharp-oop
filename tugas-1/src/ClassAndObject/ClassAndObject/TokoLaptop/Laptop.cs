using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;

        public Laptop(string merk, string prosesor, int ram, int penyimpanan)
        {
            Merk = merk;
            Prosesor = prosesor;
            Ram = ram;
            Penyimpanan = penyimpanan;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}
