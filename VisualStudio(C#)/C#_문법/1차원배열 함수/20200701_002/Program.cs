using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_002
{
    public class VariableLength
    {
        public int VarMethod(params int[] arr)
            // params 키워드는 타입 왼쪽에 기입
            // 반드시 1차원배열로 선언
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            int result;
            VariableLength vl = new VariableLength();
            result = vl.VarMethod(10, 20);
            Console.WriteLine(result);
            result = vl.VarMethod(1, 2, 3, 4);
            Console.WriteLine(result);

        }
    }
}
