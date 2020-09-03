using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200723_001
{

    class Program
    {
        delegate int Cal(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Div(int a,int b)
        {
            return a / b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            int iResult = Add(3, 4);
            Console.WriteLine(iResult);

            iResult = Div(3, 4);
            Console.WriteLine(iResult);

            iResult = Mul(3, 4);
            Console.WriteLine(iResult);

            iResult = sub(3, 4);
            Console.WriteLine(iResult);

            int iresult;
            Cal[] cals = new Cal[] { Add, Div, Mul, sub };

            for (int i = 0; i < cals.Length; i ++)
            {
                iresult = cals[i](3, 4);
                Console.WriteLine(iresult);
            }

            foreach (Cal item in cals)
            {
                iresult = item(3, 4);
                Console.WriteLine(iresult);
            }
        }
    }
}
