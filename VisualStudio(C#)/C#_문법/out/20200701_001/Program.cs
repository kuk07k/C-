using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_001
{
    public class ParamValue
    {
        public void HitDagmage(out int hit) // out 을 쓰면 쓰기용으로만 사용가능(출력용 ref효과)
        {
            hit = 11;
        }
        public static  void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("HP : {0}", i);

            ParamValue pv = new ParamValue();
            pv.HitDagmage(out i);
            Console.WriteLine("HP : {0}", i);
        }
    }
}
