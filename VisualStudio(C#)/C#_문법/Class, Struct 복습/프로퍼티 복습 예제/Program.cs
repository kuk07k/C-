using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프로퍼티_복습_예제
{
    /// <summary>
    /// Class 와 Struct 복습
    /// </summary>
    class Tclass
    {
        public int a;
        public int b;
        public string s;

        public override string ToString()
        {
            return "[" + a + "]" + "[" + b + "]" + "[" + s + "]";
        }
    }

    struct Tstruct // 구조체에서 생성자를 사용할때는 객체를 전부 생성자에 포함시켜야한다.
    {
        public int a;
        public int b;
        public string s;

        public override string ToString()
        {
            return "[" + a + "]" + "[" + b + "]" + "[" + s + "]";
        }

        public Tstruct(int temp) 
        {
            a = 100;
            b = 200;
            s = temp.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Tclass ATclass1 = new Tclass();
            //ATclass1.a = 100;
            //ATclass1.b = 101;
            //ATclass1.s = "Hello";
            //Console.WriteLine(ATclass1);

            //Tclass ATclass2 = new Tclass();
            //ATclass2.a = 102;
            //ATclass2.b = 103;
            //ATclass2.s = "Hello Kitty";
            //Console.WriteLine(ATclass2);

            //ATclass2 = ATclass1;
            //Console.WriteLine(ATclass2);

            //// 왼쪽구조체(스택), 오른쪽구조체(힙) 
            //// 메모리에 0이 들어감(a:0, b:0, s:null)
            //// Struct는 new를 써서 만드는 것은 효율이 안좋음
            //// 구조체 == 값대입
            //Tstruct Atstruct1 = new Tstruct(); 
            //Atstruct1.a = 100;
            //Atstruct1.b = 101;
            //Atstruct1.s = "헬로";
            //Console.WriteLine(Atstruct1);

            //Tstruct Atstruct2; // 구조체는 값을  대입안해주면 사용 불가 (스택에 만들어서 변수값을 초기화하지않기때문)
            //Atstruct2.a = 102;
            //Atstruct2.b = 103;
            //Atstruct2.s = "헬로 키티";
            //Console.WriteLine(Atstruct2);

            //int inum = new int(); // == > int inum = 0
            //++inum;
            //Console.WriteLine(inum);

            Tstruct tstruct1 = new Tstruct();
            Console.WriteLine(tstruct1);

            Tstruct tstruct2 = new Tstruct(700); // 생성자는 new를 썼을때만 호출가능
            Console.WriteLine(tstruct2);

        }
    }
}
