using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_002
{
    //public class A
    //{
    //    public static void MethodA() // 정적메소드 static -> 객체를 생성안하고 사용가능
    //    {
    //        System.Console.WriteLine("MethodA() in class A");
    //    }
    //}

    //public class B
    //{
    //    // 객체이름.메소드이름() : 일반적
    //    // static 메소드 == 소속.메소드이름()
    //    static void Main(string[] args) //엔트리 포인트 == static 사용
    //    {
    //        A.MethodA();
    //    }
    //}

    //===============================================//
    //============ 메소드 안에 메소드호출 ===========//
    //===============================================//

    public class A
        {
            public static void MethodA()
            {
                Console.WriteLine("메소드 A입니다.");
            }

            public static void MethodB()
            {
                MethodA();
                Console.WriteLine("메소드 B입니다.");
                MethodA();
            }

            public static void Main(string[] args)
            {
                MethodB();
                MethodA();
            }
    }
}
