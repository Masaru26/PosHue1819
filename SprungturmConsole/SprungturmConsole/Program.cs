using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprungturmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Sprungturm spt = new Sprungturm(10);
            spt.Sim();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
