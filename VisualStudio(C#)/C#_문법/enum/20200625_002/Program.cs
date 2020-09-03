using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_002
{
    enum Week // 1씩 계속 증가하는 특징을 가짐 (문자 || 숫자 형태로 사용가능)
    {
        Mon, 
        Tue = 10, 
        Wed, 
        Thu = 200, 
        Fri, 
        Sat, 
        Sun
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week GoodDay;
            Week Today;

            GoodDay = Week.Fri;
            Today = Week.Thu;

            Console.WriteLine("GoodDay = {0}", GoodDay);
            Console.WriteLine("Today   = {0}", Today);

            Console.WriteLine("GoodDay Index = {0}", (int)GoodDay);
            Console.WriteLine("Today   Index = {0}", (int)Today);

            Console.WriteLine("   Index = {0}   ", (int)Week.Mon);
            Console.WriteLine("   Index = {0}   ", (int)Week.Tue);
            Console.WriteLine("   Index = {0}   ", (int)Week.Wed);
            Console.WriteLine("   Index = {0}   ", (int)Week.Thu);
            Console.WriteLine("   Index = {0}   ", (int)Week.Fri);
            Console.WriteLine("   Index = {0}   ", (int)Week.Sat);
            Console.WriteLine("   Index = {0}   ", (int)Week.Sun);
        }
    }
}
