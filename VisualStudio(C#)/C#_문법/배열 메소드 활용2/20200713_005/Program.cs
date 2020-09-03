using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_005
{
    class Program
    {
        static int[] Test(int[] Var)
        {
            Var[0] = 99;
            return Var;
        }
        static void Main(string[] args)
        {
            int[] Array1 = new int[100];
            int[] Array2 = Test(Array1);
            Console.WriteLine(Array1[0]);
            Console.WriteLine(Array2[0]);
        }
    }
}
