using System;

namespace _20200713_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 144, 123, 232, 324, 789 };

            int index = System.Array.IndexOf(Array, 324);

            Console.WriteLine(index);

            //324의 위치를 찾는 반복문
            for (int Count = 0; Count < Array.Length; ++Count)
            {
                if(Array[Count] == 324)
                {
                    Console.WriteLine("324의 자리입니다");
                    break;
                }
            }

            //324의 위치를 찾는 2번째 방법
            Console.WriteLine("찾았따 : {0}", System.Array.IndexOf(Array, 324));
        }
    }
}
