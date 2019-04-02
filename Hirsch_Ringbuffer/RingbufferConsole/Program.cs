using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RingBuffer;

namespace RingbufferConsole
{
    class Program
    {
        static string PATH = "input.csv";
        //static Random rnd = new Random();

        static void Main(string[] args)
        {
            #region GACKS
            //List<string> val = new List<string>();

            //for (int i = 0; i < 500; i++)
            //{
            //    val.Add(i + ";" + rnd.Next(0,500) + ";");
            //}

            //File.WriteAllLines(PATH, val.ToArray());
            //Console.WriteLine("DONE");
            #endregion

            var valueList = new List<int>();

            using(StreamReader sr = new StreamReader(PATH))
            {
                string zeile = String.Empty;
                while (!sr.EndOfStream)
                {
                    zeile = sr.ReadLine();
                    var split = zeile.Split(';');

                    valueList.Add(int.Parse(split[1]));
                }
            }

            Ringbuffer<int> rb = new Ringbuffer<int>(valueList, 10);

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
