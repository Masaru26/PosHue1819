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

        private int _Last;

        /// <summary>
        /// Last = index des zueletzt eingefügten werts
        /// </summary>
        private int Newest
        {
            get
            {
                return _Last;
            }
            set
            {
                if(value >= Length)
                {
                    _Last = 0;
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

        public Ringbuffer(IList<T> ic)
        {
            this.Length = ic.Count();
            this.innerBuffer = new T[this.Length];

            for (int i = 0; i < this.Length; i++)
            {
                Write(ic[i]);
            }

            this.Newest = 0;
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
            this.Newest++;
            Read();
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
