using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class Car // 클래스안에 클래스 가능 // 안에서 맞서는 클래스
    {
        string Color;
        string Vender;
        string name;

        /*
         * 생성자
         * 1.메소드다
         * 2.클래스와 이름이 동일
         * 3.봔환 타입이 존재하지 않는다
         */

        public Car() // 디폴트 생성자 : 인자가 없는 생성자
        {
            Console.WriteLine("Car 디폴트 생성자 호출");
        }

        public Car(string name) // 생성자 오버로딩
        {
            Console.WriteLine("Car 생성자 호출");
        }


        ~Car()
        {
            Console.WriteLine("Car 소멸자 호출");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("1 ==================================");
        Car aCar = new Car("BMW"); // new 다음엔 생성자를 언급
        new Car(); // 임시객체 : 일회용객체
        Console.WriteLine("2 ==================================");
    }
}

