using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduc numerele de la tastatura 
            // x - zile in an
            // y - ore in zi
            // n - antene
            int x, y ,n;
            string line;

            line = Console.ReadLine();
            char[] seps = { ' ', '.', ',', '?' };
            string[] numere = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            n = int.Parse(numere[2]);

            // dam variabile pentru ani, zile, ore in cat ii cresc antenele
            int a, z, h;

            // impartim numarul total de antene la numarul total de ore intr-un an
            // ca rezultat primim ani 
            a = n / (x * y);
            // restul (orele) ce a ramas din impartirea antenelor la numarul de ore in an
            // impartim la numarul de ore in zi si primim zile
            z = (n % (x * y)) / y;
            // restul orelor ce au ramas dupa impartire
            h = (n % (x * y)) % y;

           
            Console.WriteLine($"{a}");
            Console.WriteLine($"{z}");
            Console.WriteLine($"{h}");


        }
    }
}
