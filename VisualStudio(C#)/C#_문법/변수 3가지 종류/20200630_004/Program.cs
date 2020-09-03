using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_004
{
    public class Example // 클래스공간은 bit 상태로 0을 다 넣어둠 (초기화)
    {
        //클래스 내부에 있는 static 변수
        //클래스 변수 == 지역변수 X(classvari1 , classvari2 : 기본적으로 0이 들어감)
        //변수에 static 을 붙이면 == 객체 전체를 통틀어 하나만 생성
        //static 변수는 적게 써야해야한다(메모리 과부화되기때문에)

        public static int classvari1; // 클래스소속 - 클래스만 있으면 존재하기에 항상 존재
        public int classvari2; // 객체소속 - 객체가 있어야 존재

        public Example()
        {
            classvari1++;
            classvari2++;
        }

        public void Print()
        {
            Console.WriteLine("classvari1 : " + classvari1);
            Console.WriteLine("classvari2 : " + classvari2);
        }

        public static void Main(string[] args)
        {
            Example e1;
            Example e2;

            e1 = new Example();
            e1.Print();

            e2 = new Example();
            e2.Print();

            e1.Print();
        }
        //============= 변수 3가지 종류 ===============//
        // 클래스 변수(영원히)
        // 인스턴스 변수 == 객체 변수(회수당하기전까지 - 객체 수명과 동일)
        // 지역 변수({ })

        //Main을 가볍게
        //Main에서 조립하기 위해
        //Class를 조각조각내서 Main으로
    }
}
