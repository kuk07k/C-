using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int point;
            string result;

            Console.Write("점수를 입력하세요 : ");
            point = int.Parse(Console.ReadLine());

            if(point > 90)
            {
                result = "A";
            }
            else if(point > 80)
            {
                result = "B";
            }
            else if (point > 70)
            {
                result = "C";
            }
            else if (point > 60)
            {
                result = "D";
            }
            else
            {
                result = "F";
            }
            Console.WriteLine("당신의 점수는 {0}입니다.", point);
            Console.WriteLine("그리고 학점은 {0}입니다.", result);
        }
    }
}
