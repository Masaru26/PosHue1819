using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprungturmConsole
{
    class Person
    {
        static Random rnd = new Random();
        static int IDintern = 0;
        public int ID { get; set; }

        public int TimeUntilBackInQueue { get; set; }

        public Person()
        {
            ID = IDintern;
            IDintern++;
        }

        public Person NewTime(int currenttime)
        {
            TimeUntilBackInQueue = currenttime + rnd.Next(10, 60);

            return this;
        }
    }
}
