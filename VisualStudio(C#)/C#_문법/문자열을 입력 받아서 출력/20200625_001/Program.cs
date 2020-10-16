//프롤로그 시작 ---------------
using System;

namespace _20200625_001
//프롤로그 끝 -----------------
{
    class Program //클래스
    {
        static void Main(string[] args)
        //Main 메소드 & 엔트리 포인트
        //Main 메소드의 인자/인수/매개변수 : 1개, 이름 : args
        //static : 정적 (Program에 객체가 없지만 Main에 접근하기 위해서)
        {
            foreach (var item in args)
            {
                Console.Write(item);
            }
            Console.WriteLine("지옥으로 키티");
            Console.WriteLine(args[0]);//솔루션이름 - 속성 - 디버그 || 프로젝트 - 프로젝트 속성
            Console.WriteLine(args[1]);//Main의 인자는 운영체제가 정해줌
            Console.WriteLine("{0:C}", 100);
            Console.WriteLine("{0:D}", 100);
            Console.WriteLine("{0:E}", 100);
            Console.WriteLine("{0:F}", 100);
            Console.WriteLine("{0:G}", 100);
            Console.WriteLine("{0:N}", 100);
            Console.WriteLine("{0:X}", 100);

            //inValue 변수로 문자열을 입력 받아서 출력하는 소스 작성
            //Console.Write("입력하세요 : ");
            //string inValue1 = Console.ReadLine();
            //Console.WriteLine("입력값은 : {0} 입니다.", inValue1);

            //Console.Write("변수를 입력하세요 : ");
            //int inValue = int.Parse(Console.ReadLine());
            //Console.WriteLine("입력하신 값은 {0} 입니다", inValue);

            //int iNumber = 0x12345678;
            float fNumber = 41.625f;

        }
    }
}
