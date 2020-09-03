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
            int i = 0;
            int[] ClearArray = { 5, 4, 2, 6, 7, 1 };
            System.Array.Clear(ClearArray, 1, 2);

            for (i = 0; i < ClearArray.Length; i++)
            {
                Console.WriteLine(ClearArray[i]);
            }
        }
    }
}
