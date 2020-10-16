using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_010
{
    class ArrayClear2
    {
        static void Main(string[] args)
        {
            int[] ClearArray = new int[3] { 23, 434, 55 };
            Array.Clear(ClearArray, 2, 1);
            for (int i = 0; i < ClearArray.Length; i++)
            {
                Console.WriteLine(ClearArray[i]);
            }
        }
    }
}
