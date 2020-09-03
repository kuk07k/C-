using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_007
{
    public class ParamRef
    {
        public int myVal = 10;
    }
    public class ParamTest
    {
        public static void Increase(ref ParamRef varRef)
        {
            varRef.myVal++;
        }
    
        static void Main(string[] args)
        {
            ParamRef pr = new ParamRef();
            Console.WriteLine("호출 전 : {0}", pr.myVal);
            ParamTest.Increase(ref pr);
            Console.WriteLine("호출 후 : {0}", pr.myVal);
        }
    }
}
