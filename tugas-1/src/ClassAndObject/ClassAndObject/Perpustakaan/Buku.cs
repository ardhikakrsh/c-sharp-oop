using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int TahunTerbit;

        public Buku(string judul, string penulis, int tahunTerbit)
        {
            Judul = judul;
            Penulis = penulis;
            TahunTerbit = tahunTerbit;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }

}
