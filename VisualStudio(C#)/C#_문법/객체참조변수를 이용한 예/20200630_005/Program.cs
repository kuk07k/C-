using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_005
{
    using System;

    public class ParamValue
    {
        public void Increase(int n)
        {
            n++;
        }
    }
    public class ParamRef
    {
        public int myVal = 10;
    }
    public class ParamTest
    {
        public static void Increase(ParamRef varRef)
        {
            varRef.myVal++;
        }
        public static void Main(string[] args)
        {
            int i = 10;
            ParamValue pv = new ParamValue();
            Console.WriteLine("호출 전 : {0}", i);
            pv.Increase(i);
            Console.WriteLine("호출 후 : {0}", i);

            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}", pr.myVal);
            ParamTest.Increase(pr); // 객체참조변수를 이용한 예
            Console.WriteLine("호출 후 : {0}", pr.myVal);
        }
    }
}
