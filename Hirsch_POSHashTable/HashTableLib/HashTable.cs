using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HashTableLib
{
    public class HashTable
    {
        private Person[] innerTable;

        public int Length { get; protected set; }

        public int CollisionCount { get; set; }

        public HashTable(int length)
        {
            Length = length - 1;
            this.innerTable = new Person[Length];
            CollisionCount = 0;
        }

        public int GetIdx(Person p)
        {
            return  (int)(BigInteger.Abs(p.hashBigInt) % Length) - 1;
        }

        public void AddElement(Person p)
        {
            int idxFElement = GetIdx(p);
            
            if (innerTable[idxFElement] == null)
            {
                innerTable[idxFElement] = p;
                p.isInserted = true;
            }
            else
            {
                int idx = idxFElement;
                idx++;
                while (!p.isInserted)
                {
                    if(idx == 0)
                    {
                        if (innerTable[idx] == null)
                        {
                            innerTable[idx] = p;
                            p.isInserted = true;
                        }
                        else
                        {
                            if (idx != idxFElement)
                            {
                                if (idx == Length)
                                {
                                    idx = 0;
                                }
                                else
                                {
                                    idx++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Item not insertable. Too many collisions");
                                break;
                            }

                            CollisionCount++;
                        }

                    }

                    if (innerTable[idx - 1] == null)
                    {
                        innerTable[idx - 1] = p;
                        p.isInserted = true;
                    }
                    else
                    {
                        if (idx != idxFElement)
                        {
                            if (idx == Length)
                            {
                                idx = 0;
                            }
                            else
                            {
                                idx++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Item not insertable. Too many collisions");
                            break;
                        }
                        CollisionCount++;
                    }

                }
            }
        }

        public Person[] GetTable()
        {
            return innerTable;
        }
    }
}
