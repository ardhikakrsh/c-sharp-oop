
using System;

namespace Warmup.HelloCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string input = "";

            while (input != "exit")
            {
                Console.WriteLine("Masukkan angka pertama:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih operasi (Tambah, Kurang, Kali, Bagi):");
                string operasi = Console.ReadLine();

                while (true)
                {
                    if (operasi == "Tambah")
                    {
                        calculator.Tambah(a, b);
                        break;
                    }
                    else if (operasi == "Kurang")
                    {
                        calculator.Kurang(a, b);
                        break;
                    }
                    else if (operasi == "Bagi")
                    {
                        calculator.Bagi(a, b);
                        break;
                    }
                    else if (operasi == "Kali")
                    {
                        calculator.Kali(a, b);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operasi");
                        break;
                    }
                }

                Console.WriteLine("Ketik 'exit' untuk keluar, atau Enter untuk melanjutkan.");
                input = Console.ReadLine();
            }
        }
    }

}


