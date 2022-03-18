using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorconsole
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Menu Calculator ");
                Console.WriteLine("1. Penambahan ");
                Console.WriteLine("2. Pengurangan ");
                Console.WriteLine("3. Perkalian ");
                Console.WriteLine("4. Pembagian ");
                Console.Write("\nSilahkan Pilih Menu : ");
                int menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine("Penambahan");
                    Console.Write("Inputkan nilai a : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Press Key untuk menampilkan Hasil ");
                    Console.ReadKey();
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Pengurangan");
                    Console.Write("Inputkan nilai a : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Press Key untuk menampilkan Hasil ");
                    Console.ReadKey();
                    Console.WriteLine("Hasil Perngurangan " + a + " - " + b + " = " + pengurangan(a, b));
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Perkalian");
                    Console.Write("Inputkan nilai a : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Press Key untuk menampilkan Hasil ");
                    Console.ReadKey();
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, +perkalian(a, b));
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Pembagian");
                    Console.Write("Inputkan nilai a : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan nilai b : ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Press Key untuk menampilkan Hasil ");
                    Console.ReadKey();
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, +pembagian(a, b));
                }
                else
                {
                    Console.WriteLine("Menu yang anda inputkan salah");
                }

                for (int y = 1; y <= 3; y++) {
                    Console.Write("\nApakah ingin kembali ke awal ? (Y/T) : ");
                    char loop = Convert.ToChar(Console.ReadLine());

                    if (loop == 'y' || loop == 'y')
                    {
                        i = 1;
                        y = 4;
                    }
                    else if (loop == 'T' || loop == 't')
                    {
                        i = 2;
                        y = 4;
                    }
                    else
                    {
                        Console.WriteLine("Char yang anda input salah");
                    }
                }
                Console.Clear();

            } while (i <= 1);

        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}