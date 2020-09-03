using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_003
{
    public class A
    {
        public static ulong Factorial(ulong number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else 
            {
                return number * Factorial(number - 1);
            }
        }

        public static void Main(string[] args)
        {
            ulong nfact = Factorial(5);
            Console.WriteLine("5 * 4 * 3 * 2 * 1 = " + nfact);

            //=================================================//
            //============= 변수 초기화하는 이유 ==============//
            //=================================================//

            // int localVar = 10;
            // int unInitVar;
            // Console.WriteLine(localVar);
            // Console.WriteLine(unInitVar);

            // 메소드안에 만들어지는 변수 : 지역변수
            // 지역변수안에 값을 안넣어줬기때문에
            // 메모리공간을 할당받지만 쓰레기값이다
            // 따라서 초기화를 통해 쓰레기값을 없앤다.
        }
    }
}
