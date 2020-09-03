using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200727_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 100;
            unsafe
            {
                Console.WriteLine("{0:x}", (int)&iNum);
            }
        }
    }
}
