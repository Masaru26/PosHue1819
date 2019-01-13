using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HashTableLib;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Schülerliste 3-5 Klasse V2.csv");

            List<Person> pList = new List<Person>();

            int idx = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                if(idx != 0)
                {
                    string[] split = s.Split(';');

                    Person p = new Person(split[0], split[1], split[2]);

                    pList.Add(p);
                }

                idx++;
            }

            HashTable ht = new HashTable((int)(idx*1.3));

            pList.ForEach(x => 
            {
                ht.AddElement(x);
            });

            var list = ht.GetTable();
            int count = 0;
            list.ToList().ForEach(x =>
            {
                if (x != null)
                {
                    Console.WriteLine(count + ": " + x.ToString());
                    count++;
                }
            });

            Console.WriteLine("Collision Count: " + ht.CollisionCount);

            Console.ReadKey();
        }
    }
}
