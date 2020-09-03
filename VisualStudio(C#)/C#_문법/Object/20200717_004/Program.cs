using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200717_004
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1 = 100;

            Object aObject = iNum1;
              
            int iNum2 = (int)aObject;

            Console.WriteLine(iNum1);
            Console.WriteLine(aObject);
            Console.WriteLine(iNum2);
        }
    }
}
