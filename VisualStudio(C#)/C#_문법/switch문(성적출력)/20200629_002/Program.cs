using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 23;

            //switch (num % 5)
            //{
            //    case 1:
            //        Console.WriteLine("나머지의 값은 1입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("나머지의 값은 2입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("나머지의 값은 3입니다.");
            //        break;
            //    case 4:
            //        Console.WriteLine("나머지의 값은 4입니다.");
            //        break;

            //    default:
            //        Console.WriteLine("5의 배수입니다.");
            //        break;
            //}

            int point;

            Console.Write("점수를 입력하세요 : ");
            point = int.Parse(Console.ReadLine());
            
            switch (point / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A학점입니다.");
                    break;
                case 8:
                    Console.WriteLine("B학점입니다.");
                    break;
                case 7:
                    Console.WriteLine("C학점입니다.");
                    break;
                case 6:
                    Console.WriteLine("D학점입니다.");
                    break;

                default:
                    Console.WriteLine("E학점입니다.");
                    break;

            }
        }
    }
}
