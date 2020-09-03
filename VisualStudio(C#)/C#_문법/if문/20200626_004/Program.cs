using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200626_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("포인트를 입력하세요 : ");
            int point = int.Parse(Console.ReadLine());
            
            string result;

            if((point >= 0) && (point <= 100)) // if () : ()안에는 bool타입만 가능
            {
                if (point > 50) // if문의 중첩 // 중괄호 제거 가능
                {
                    result = "Pass";
                }
                else
                {
                    result = "Fail";
                }
                Console.WriteLine("결과 : " + result);
            }
            else
            {
                Console.WriteLine("에러 : 범위를 벗어났습니다.");
            }
        }
    }
}
