using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200723_002
{
    class Program
    {
        delegate int NewType(int Num); // delegate를 활용하여 반복문에 사용

        static int OnePlus(int Num)
        {
            return Num + 1;
        }

        static int TenPlus(int Num)
        {
            return Num + 10;
        }

        static void Main(string[] args)
        {
            int TestNum = OnePlus(100);
            Console.WriteLine(TestNum);

            NewType newType = new NewType(OnePlus);
            TestNum = newType(1000);
            Console.WriteLine(TestNum);

            NewType anewType = new NewType(TenPlus);
            TestNum = anewType(1000);
            Console.WriteLine(TestNum);
        }
    }
}
