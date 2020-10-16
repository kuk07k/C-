using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_003
{
    public class ParamValue
    {
        public static void VarMethod(params object[] arr)
        {
            Console.WriteLine("[가변 인자 개수]   : " + arr.Length);

            Console.Write("[인자 전체]  : ");
            foreach (var one in arr)
            {
                Console.Write(one.ToString() + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Type t = arr[i].GetType();
                if (t.Equals(typeof(string)))
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.Write("[문자열 타입] : ");
            for(int i = 0; i < arr.Length; ++i)
            {
                Type t = arr[i].GetType(); // 1000에서의 타입을 추출하라
                if (t.Equals(typeof(System.String)))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[정수 타입]  : ");
            foreach(object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Int32)))
                {
                    Console.Write(one + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[Float 타입]  : ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Single)))
                {
                    Console.Write(one + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[Double 타입]  : ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Double)))
                {
                    Console.Write(one + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            VarMethod(1000, 2000, "3000", "헬로", 3.1, 3.2f);
        }
    }
}
