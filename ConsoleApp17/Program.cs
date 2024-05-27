using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] massive = { 5.1, 1.3, 9.2, 2, 3, 5.1, 3 };

                var ch = massive
                    .GroupBy(n => n)
                    .Select(g => new { Chislo = g.Key, Chastota = g.Count() });

                Console.WriteLine("Число Номер Частота");
                Console.WriteLine("--------------------");

                foreach (var nf in ch)
                {
                    Console.WriteLine($"{nf.Chislo} - {nf.Chastota}");
                }

                var new_massive = massive.Select(num => num * ch.First(nf => nf.Chislo == num).Chastota);

                Console.WriteLine("\nЧисло Номер Частота(старого массива)");
                Console.WriteLine("--------------------------------");

                foreach (var num in new_massive)
                {
                    Console.WriteLine($"{num} - {ch.First(nf => nf.Chislo == num / nf.Chastota).Chastota}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }         
            Console.Read();                                        
        }
    }
}
