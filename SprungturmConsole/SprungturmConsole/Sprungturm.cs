using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SprungturmConsole
{
    class Sprungturm
    {
        StreamWriter sw;

        public Queue<Person> PeopleQueue{ get; set; }

        public int PeopleCount
        {
            get
            {
                return PeopleQueue.Count;
            }
        }

        public Sprungturm(int anzPers)
        {
            this.PeopleQueue = new Queue<Person>();
            for (int i = 0; i < anzPers; i++)
            {
                this.PeopleQueue.Enqueue(new Person());
            }
            sw = new StreamWriter("Log.log");
        }

        public void Sim()
        {
            List<Person> plList = new List<Person>();
            // in 10 sek
            (int t, int length) longestQueue = (0,0);
            for (int i = 0; i < 1200; i+=10)
            {
                if(i % 60 == 0)
                {
                    PeopleQueue.Enqueue(new Person());
                }

                if(i % 20 == 0)
                {
                    plList.Add(PeopleQueue.Dequeue().NewTime(i));
                }

                for(int t = plList.Count - 1; t >= 0; t--)
                {
                    if(plList[t].TimeUntilBackInQueue >= i)
                    {
                        PeopleQueue.Enqueue(plList[t]);
                        plList[t].TimeUntilBackInQueue = 0;
                        plList.Remove(plList[t]);
                    }
                }
                sw.WriteLine("T: " + i + " Length: " + PeopleCount);
                if (PeopleCount > longestQueue.length)
                    longestQueue = (i, PeopleCount);
            }

            for (int i = 1200; i < 1800; i+=10)
            {
                if (i % 60 == 0)
                {
                    PeopleQueue.Dequeue();
                    PeopleQueue.Dequeue();
                }

                if (i % 20 == 0)
                {
                    plList.Add(PeopleQueue.Dequeue().NewTime(i));
                }

                for (int t = plList.Count - 1; t >= 0; t--)
                {
                    if (plList[t].TimeUntilBackInQueue >= i)
                    {
                        PeopleQueue.Enqueue(plList[t]);
                        plList[t].TimeUntilBackInQueue = 0;
                        plList.Remove(plList[t]);
                    }
                }

                sw.WriteLine("T: " + i + " Length: " + PeopleCount);

                if (PeopleCount > longestQueue.length)
                    longestQueue = (i, PeopleCount);
            }


            sw.WriteLine("LongestQueue: T:" + longestQueue.t / 60 + " Length: " + longestQueue.length);
            Console.WriteLine("LongestQueue: T:" + longestQueue.t / 60 + " Length: " + longestQueue.length);
            sw.Close();
        }

    }
}
