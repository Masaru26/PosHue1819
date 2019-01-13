using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StreckenUPunkte;

namespace StreckenTest
{
    class Program
    {
        public static Strecke[] strecken = {
            new Strecke(new Punkt(3, 5), new Punkt(7, 6)),
            new Strecke(new Punkt(3, 6), new Punkt(8, 7)),
            new Strecke(new Punkt(4, 7), new Punkt(9, 7)),
            new Strecke(new Punkt(10, 11), new Punkt(12, 13))
        };

        static void Main(string[] args)
        {

            foreach (var item in strecken)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();

        }
    }
}