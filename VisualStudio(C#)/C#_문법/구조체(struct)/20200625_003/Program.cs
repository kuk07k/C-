using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_003
{
    struct Book // 클래스와 비슷 // 구조체 (간단한 입출력을 활용할때 사용) // 값에 따라 달라짐
    {
        public string name; // string 변수
        public int price; // int 변수
        public void test() // 메서드
        {
            Console.WriteLine("심심하다 메서드");
            Console.WriteLine(price);
        }
        static Book() // static 생성자
        {
            Console.WriteLine("static 생성자");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main 시작");
            Book abook = new Book();
            abook.name = "test";
            abook.price = 100;
            abook.test();
        }
    }
}
