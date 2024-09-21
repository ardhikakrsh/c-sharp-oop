
using System;
using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("Mau Apa Lagi?", "Dhika", 2024);
            buku1.TampilkanInfo();

            // Kendaraan
            Mobil mobil1 = new Mobil("Nisan", "GTR R-34", 2003);
            mobil1.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop1 = new Laptop("ROG", "Ryzen 6900S", 16, 1000);
            laptop1.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda1.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator1 = new Kalkulator();
            Console.WriteLine(kalkulator1.Tambah(7, 1));
            Console.WriteLine(kalkulator1.Kurang(7, 1));
            Console.WriteLine(kalkulator1.Kali(7, 1));
            Console.WriteLine(kalkulator1.Bagi(7, 1));

        }
    }
}
