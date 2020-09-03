using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LINQ
{
    class Program
    {
        static void Print(List<int> alist1)
        {
            foreach (var item in alist1)
            {
                Console.Write($"    {item}");
            }
            Console.WriteLine();
        }

        static void Main1(string[] args)
        {
            List<int> alist1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> alist2 = new List<int>();

            foreach (var item in alist1) // alist1에서 alist2로 복사
            {
                alist2.Add(item);
            }

            Print(alist1); // 출력
            Print(alist2);
        }

        static void Main(string[] args)
        {
            List<int> alist1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> alist2;

            //var Fact = from Temp in alist1 select Temp;
            //alist2 = Fact.ToList<int>();
           
            alist2 = (from Temp in alist1 select Temp).ToList<int>(); // 임시객체

            Print(alist2);
        }
    }
}
