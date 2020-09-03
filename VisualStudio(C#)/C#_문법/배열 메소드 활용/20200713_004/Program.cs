using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_004
{
    class Program
    {
        static void test(int[] var)
        {
            Console.WriteLine(var.Length);
        }
        static void Main(string[] args)
        {
            int[] Array = new int[5];
            test(Array);
        }
    }
}
