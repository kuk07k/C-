using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_006
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            long[] Original = new long[4] { 3, 1, 2, 0 };
            long[] Copy = Original; // original과 같은곳을 가리킴
            Console.WriteLine("1 : " + Copy[3]);
            Original[3] = Original[1] + Original[2];

            long CopyValue = Copy[3];
            Console.WriteLine("2 : " + CopyValue);
        }
    }
}
