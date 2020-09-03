using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_003_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] iArray = new int[5];
            //iArray = {0,1,2,3,4};


            //int[] iArray = new int[5] {0,1,2,3,4};
            //int[] iArray;
            //iArray = new int[5] { 0, 1, 2, 3, 4 };


            /*int[] iArray = new int[50] {
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4,
                0,1,2,3,4
            };*/

            //int[] iArray = new int[5] { 0, 1, 2, 3, 4 };

            //for (int i = 0; i < iArray.Length; ++i)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in iArray)
            //{
            //    Console.WriteLine(i);
            //}

            //==============continue / break==================//
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    continue; // 반복문을 계속

                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    break; // 현재위치에서 종료

                Console.Write("{0} ", i);
            }
            Console.WriteLine();


        }
    }
}
