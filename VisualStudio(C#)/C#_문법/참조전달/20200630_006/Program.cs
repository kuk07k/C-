using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_006
{
    //=========== 참조전달 ===========//
    public class ParamValue
    {
        public void Increase(ref int n) 
            //ref int n // i == (n)이라는 이름을 하나 더 만든다(별칭)
        {
            n++;
        }
        public void Increase1(ref int n)
        {
            n++;
        }
        public static void Main(string[] args)
        {
            int i = 10;
            ParamValue pv = new ParamValue();
            Console.WriteLine("호출 전 : {0}", i);
            pv.Increase(ref i);
            Console.WriteLine("호출 후 : {0}", i);
            pv.Increase1(ref i);
            Console.WriteLine("호출 후 : {0}", i);
        }
    }
}
