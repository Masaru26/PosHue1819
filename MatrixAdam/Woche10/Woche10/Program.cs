using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woche10
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> mat = new Matrix<int>(4, 4);
            Console.WriteLine(mat.ToString());
            Console.WriteLine(mat.ToStringVerbose());
            mat.AddColumn();
            Console.WriteLine(mat.ToString());
            mat.InsertRow(2);
            Console.WriteLine(mat.ToString());
            mat.InsertColumn(2);
            Console.WriteLine(mat.ToString());
            mat.Resize(5, 5);
            Console.WriteLine(mat.ToString());
            mat.DeleteRow(2);
            Console.WriteLine(mat.ToString());
            mat.DeleteColumn(2);
            Console.WriteLine(mat.ToString());
            Console.WriteLine("Size: " + mat.Size());
            Console.ReadKey();
        }
    }
}
