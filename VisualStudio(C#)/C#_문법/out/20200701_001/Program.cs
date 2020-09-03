using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_001
{
    public class ParamValue
    {
        public void Increase(out int n) // out 을 쓰면 쓰기용으로만 사용가능(출력용 ref효과)
        {
            n = 11;
            Console.WriteLine(n);
        }
        public static  void Main(string[] args)
        {
            int i = 6;
            ParamValue pv = new ParamValue();
            pv.Increase(out i);
            Console.WriteLine("호출후 값 : {0}", i);
        }
    }
}
