using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_003
{
    class Program
    {
        public static int[] Test()
        {
            int[] Array = new int[5];

            return Array;
        }
        static void Main(string[] args)
        {
            int[] Ret = Test();

            Console.WriteLine(Ret.Length);
        }
    }
}
