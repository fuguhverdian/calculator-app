using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progam_kalkulator
{
    class Program
    {

        static void Main(string[] args)
        {
            double a, b;
            int pil;
            Console.Title = "aplikasi kalkulator";
            Console.WriteLine("Pilih menu kalkulator : ");
            Console.WriteLine("1. Penjumlahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian ");
            Console.WriteLine();
            Console.Write("masukan pilihan:");
            pil = Convert.ToInt32(Console.ReadLine());
            switch (pil)
            {
                case 1 :
                    Console.Write("inputkan nilai a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("inputkan nilai b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2} ",a,b, penambahan(a,b));
                    break;
                case 2:
                    Console.Write("inputkan nilai a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("inputkan nilai b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.Write("inputkan nilai a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("inputkan nilai b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.Write("inputkan nilai a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("inputkan nilai b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil pembagian {0} / {1} = {2} ", a, b, pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang anda pilih tidak sesuai!");
                    break;
            }


        
            Console.ReadKey();
        }
        static double penambahan(double a, double b)
        {
            return a + b;
        }
        static double pengurangan(double a, double b)
        {
            return a - b;
        }
        static double perkalian(double a, double b)
        {
            return a * b;
        }
        static double pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
