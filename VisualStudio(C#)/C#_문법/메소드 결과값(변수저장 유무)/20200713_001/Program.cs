using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_001
{
    class Program
    {
        static int Add (int N1, int N2)
        {
            Console.WriteLine("저는 [int형] 입니다");
            return N1 + N2;
        }

        static float Add (float N1, float N2)
        {
            Console.WriteLine("저는 [float형] 입니다");
            return N1 + N2;
        }

        static double Add(double N1, double N2)
        {
            Console.WriteLine("저는 [double형] 입니다");
            return N1 + N2;
        }

        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1.0, 2.0);
            Add(1.0f, 2.0f);

            // 메소드의 결과값을 저장하는 경우 (변수에 저장하여 활용)
            int inum = Add(1, 2); 
            Console.WriteLine(inum);

            // 메소드의 결과값을 저장하지 않고 활용하는 경우
            if (3 == Add(1,2))
            {
                Console.WriteLine("결과는 3입니다");
            }
        }
    }
}
