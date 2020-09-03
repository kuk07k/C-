using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //===================================================//
            //============ 제대로 입력할때까지 반복 =============//
            //===================================================//

            int a, b;
            float c = 0;

            while (true)
            {
                try
                {
                    Console.Write("변수1을 입력 : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("변수2을 입력 : ");
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                }

                catch (FormatException Aobj)
                {
                    Console.WriteLine(Aobj);
                    Console.WriteLine("문자를 입력하셨습니다.");
                    continue;
                }

                catch (Exception Aobj)
                {
                    Console.WriteLine(Aobj);
                    Console.WriteLine("변수의 값이 올바르지 않습니다.");
                    continue;
                }

                finally
                {
                    Console.WriteLine("프로그램이 실행 되었습니다.");
                }

                Console.WriteLine("A/B값은 {0}입니다.", c);
                break;

            }
        }
    }
}
