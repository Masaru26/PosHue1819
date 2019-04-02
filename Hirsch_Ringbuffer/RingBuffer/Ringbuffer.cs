using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class Ringbuffer<T>
    {
        T[] innerBuffer;

        #region Properties
    
        public int Length { get; set; }

        private int _Newest;

        /// <summary>
        /// Last = index des zueletzt eingefügten werts
        /// </summary>
        private int Newest
        {
            get
            {
                return _Newest;
            }
            set
            {
                if(value >= Length)
                {
                    _Newest = 0;
                }
                else
                {
                    _Newest = value;
                }
            }
        }

        #endregion

        #region Constructors

        public Ringbuffer(int Length)
        {
            this.Length = Length;
            this.innerBuffer = new T[this.Length];

            this.Newest = 0;
        }

        public Ringbuffer(IList<T> ic, int Length)
        {
            this.Length = Length;
            this.innerBuffer = new T[this.Length];

            this.Newest = 0;

            for (int i = 0; i < ic.Count(); i++)
            {
                Write(ic[i]);
            }
        }

        #endregion

        #region Methods

        public void Read()
        {
            Console.WriteLine(this.Newest + ": " + innerBuffer[this.Newest]);
        }

        public void Write(T value)
        {
            innerBuffer[this.Newest] = value;
            Read();
            this.Newest += 1;
        }

        public void Peek(int idx)
        {
            Console.WriteLine(idx + ": " + innerBuffer[idx]);
        }

        /*
        public void Output()
        {
            throw new NotImplementedException();
        }
        */
        #endregion
    }
}
