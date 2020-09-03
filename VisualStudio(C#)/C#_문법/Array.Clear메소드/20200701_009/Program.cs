using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_009
{
    class ArrayClear1
    {
        static void Main(string[] args)
        {
            int[] clearArray = { 5, 4, 2, 6, 7, 1 };

            Console.WriteLine("**************************클리어 전***********************");
            foreach (int num in clearArray)
            {
                Console.WriteLine(num);
            }

            Array.Clear(clearArray, 0, clearArray.Length);
            Console.WriteLine("**************************클리어 후***********************");
            foreach (int num in clearArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
