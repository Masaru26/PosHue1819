using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CuckooLib
{
    public class Person
    {
        public int F1Pos { get; set; }
        public int F2Pos { get; set; }

        // 0 == F1Pos   1 == F2Pos
        public int wPos { get; set; }

        public BigInteger BigIntHash { get; set; }

        public string HashString { get; set; }

        public Person()
        {
            this.wPos = 0;
            CalHash();
        }

        public void CalHash()
        {

        }
        
        /*public Person[] CheckPos(Person[] iT)
        {
            if (wPos == 0)
            {
                if (iT[F2Pos] == null)
                {
                    iT[F2Pos] = this;
                    wPos = 1;
                    return iT;
                }
                else
                {
                    iT[F2Pos].CheckPos(iT);
                    wPos = 1;
                    return iT;
                }
            }
            else if (wPos == 1)
            {
                if (iT[F1Pos] == null)
                {
                    iT[F1Pos] = this;
                    wPos = 0;
                    return iT;
                }
                else
                {
                    iT[F1Pos].CheckPos(iT);
                    wPos = 0;
                    return iT;
                }
            }
            else
            {
                Console.WriteLine("Cannot be something else than 0 or 1.");
                return null;
            }
        }*/
    }
}
