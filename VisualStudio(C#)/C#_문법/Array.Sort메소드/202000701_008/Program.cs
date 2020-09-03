using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202000701_008
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            int i = 0;

            //배열선언
            int[] SortArray = new int[5] { 15, 32, 11, 20, 43 };

            Console.WriteLine("현재배열 출력 : ");
            for ( i = 0;  i < SortArray.Length;  i++)
            {
                Console.WriteLine(SortArray[i]);
            }

            //foreach (var item in SortArray)
            //{
            //    Console.WriteLine(item);
            //}

            //Sort메소드로 배열정렬
            Array.Sort(SortArray);

            Console.WriteLine("정렬된 배열 출력 : ");
            for ( i = 0; i < SortArray.Length; i++)
            {
                Console.WriteLine(SortArray[i]);
            }

            //foreach (var item in SortArray)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
