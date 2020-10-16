using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 5, 667, 24, 3 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int[] array2 = new int[3];
            array2 = { 23,454};

            int result = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                result = result + array2[i];
                Console.WriteLine(result);
            }
        }
    }
}
