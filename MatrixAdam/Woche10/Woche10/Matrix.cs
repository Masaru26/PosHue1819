using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woche10
{
    class Matrix<T>
    {
        T[,] map;
        public Matrix(int n, int m)
        {
            map = new T[n, m];
        }
        
        public decimal Size()
        {
            return map.Length * sizeof(int);
        }
        public void AddRow()
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(),new int[] { map.GetUpperBound(0) + 2, map.GetUpperBound(1) + 1}) as T[,];
            for (int i = 0; i < Temp.GetUpperBound(0) && i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < Temp.GetUpperBound(1) && i2 < map.GetUpperBound(1); i2++)
                {
                    Temp[i, i2] = map[i, i2];
                }
            }
            map = Temp as T[,];
        }
        public void AddColumn()
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] { map.GetUpperBound(0) + 1, map.GetUpperBound(1) + 2 }) as T[,];
            for (int i = 0; i < Temp.GetUpperBound(0) && i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < Temp.GetUpperBound(1) && i2 < map.GetUpperBound(1); i2++)
                {
                    Temp[i, i2] = map[i, i2];
                }
            }
            map = Temp as T[,];
        }
        public void InsertRow(int row_index)
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] { map.GetUpperBound(0) + 2, map.GetUpperBound(1) + 1 }) as T[,];
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    if (i >= row_index)
                    {
                        Temp[i +1 ,i2] = map[i, i2];
                    }
                    else
                    {
                        Temp[i, i2] = map[i,i2];
                    }
                }
            }
            map = Temp as T[,];
        }
        public void InsertColumn(int column_index)
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] { map.GetUpperBound(0) + 1, map.GetUpperBound(1) + 2 }) as T[,];
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    if (i2 >= column_index)
                    {
                        Temp[i, i2+1] = map[i, i2];
                    }
                    else
                    {
                        Temp[i, i2] = map[i, i2];
                    }
                }
            }
            map = Temp as T[,];
        }

        public void Resize(int new_n_dimension,int new_m_dimension)
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] {new_n_dimension+1, new_m_dimension+1}) as T[,];
            int length = map.Length <= Temp.Length ? map.Length : Temp.Length;
            Array.ConstrainedCopy(map, 0, Temp, 0, length);

            for (int i = 0; i < Temp.GetUpperBound(0) && i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < Temp.GetUpperBound(1) && i2 < map.GetUpperBound(1); i2++)
                {
                    Temp[i, i2] = map[i, i2];
                }
            }
            map = Temp as T[,];
        }
        public void DeleteRow(int row_index)
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] { map.GetUpperBound(0) + 0, map.GetUpperBound(1) + 1 }) as T[,];
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    if (i > row_index)
                    {
                        Temp[i, i2] = map[i+1, i2];
                    }
                    else
                    {
                        Temp[i, i2] = map[i, i2];
                    }
                }
            }
            map = Temp as T[,];
        }
        public void DeleteColumn(int column_index)
        {
            var Temp = Array.CreateInstance(map.GetType().GetElementType(), new int[] { map.GetUpperBound(0) + 1, map.GetUpperBound(1) + 0 }) as T[,];
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    if (i2 > column_index)
                    {
                        Temp[i, i2] = map[i, i2+1];
                    }
                    else
                    {
                        Temp[i, i2] = map[i, i2];
                    }
                }
            }
            map = Temp as T[,];
        }
        public string ToStringVerbose()
        {
            string temp = "  ";
            for (int i = 0; i < map.GetUpperBound(1); i++)
            {
                temp += i + " ";
            }
            temp += "\n";
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                temp += i + ":";
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    temp += map[i, i2] + " ";
                }
                temp += "\n";
            }
            return temp;
        }
        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < map.GetUpperBound(0); i++)
            {
                for (int i2 = 0; i2 < map.GetUpperBound(1); i2++)
                {
                    temp += map[i, i2] + " ";
                }
                temp += "\n";
            }
            return temp;
        }



    }
}
