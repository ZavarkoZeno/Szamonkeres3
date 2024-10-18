using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamonkeres3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int napok = 7;
            double[] hőmérséklet = new double[napok];

            for (int i = 0; i < napok; i++)
            {
                Console.Write($"Adja meg a {i + 1}. napi hőmérsékletet: ");
                while (!double.TryParse(Console.ReadLine(), out hőmérséklet[i]))
                {
                    Console.WriteLine("Érvényes hőmérsékletet adj meg");
                }
            }

            double sum = 0;
            double maxhőmérséklet = hőmérséklet[0];
            double minhőmérséklet = hőmérséklet[0];
            bool Fagyosnap = false;

            for (int i = 0; i < napok;i++)
            {
                sum += hőmérséklet[i];

                if (hőmérséklet[i] > maxhőmérséklet)
                    maxhőmérséklet = hőmérséklet[i];

                if (hőmérséklet[i] > minhőmérséklet)
                    minhőmérséklet = hőmérséklet[i];
            }
        }
    }
}
