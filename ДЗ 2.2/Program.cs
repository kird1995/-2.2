using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fc = true;
            double start = 0;
            Menu(start);
           
        }
        static double Menu(double start)
        {
            string ravno0 = "Начальное значение результата равно 0.";
            string d2 = " 1.Добавить двойку к результату.\n";
            string v3 = " 2.Вычесть тройку из результата.\n";
            string u2 = " 3.Удвоить результат.\n";
            string r5 = " 4.Разделить результат на 5.\n";
            string v100 = " 5.Вычесть результат из ста.\n";
            string exit = " 6.Вывести результат и выйти из программы.\n";
            string k11 = "Число кратно 11.";
            Console.Write(ravno0 + "\n" + d2 + v3 + u2 + r5 + v100 + exit);
            while (true)
            {
                Console.Write("Введите число: ");
                if (double.TryParse(Console.ReadLine(), out double chislo))
                {
                    if (chislo == 1)
                    {
                        start += 2;
                    }
                    if (chislo == 2)
                    {
                        start -= 3;
                    }
                    if (chislo == 3)
                    {
                        start = start * 2;
                    }
                    if (chislo == 4)
                    {
                        start /= 5;
                    }
                    if (chislo == 5)
                    {
                        start = 100 - start;
                    }
                    if (chislo == 6)
                    {
                        Console.WriteLine("Значение результата = {0}.", start);
                        return start;
                    }
                    if (start % 11 == 0)
                    {
                        Console.WriteLine(k11); 
                    }
                }
                Console.WriteLine();
            }
        }
        
    }
}

