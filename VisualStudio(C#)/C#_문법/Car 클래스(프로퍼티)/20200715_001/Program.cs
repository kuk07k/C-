using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

class Program
{
    class Car
    {
        const int iNum1 = 10; // 유일무이
        readonly int iNum2; // 생성할때 값이 고정

        string _color;
        string _vender;
        string _name;
        
        //프로퍼티 기법 (get/set)
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                value = "Auto : " + value;
                this._name = value;
            }
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            name = "Auto : " + name;
            this._name = name;
        }

        public void Print()
        {
            Console.WriteLine("---[{0}],[{1}],[{2}]---",_name,_vender,_color);
        }

        public Car() // 디폴트 생성자
        {
            Console.WriteLine("Car 디폴트 생성자 호출");
        }

        public Car(string name) 
            : this(name,null, null) { } // 생성자 오버로딩

        public Car(string name, string vender) 
            : this(name,vender, null) { }

        public Car(string name, string vender, string color)
        {
            this._name = name;
            this._vender = vender;
            this._color = color;
            Console.WriteLine("Car 생성자 호출");
        }

        ~Car()
        {
            Console.WriteLine("Car 소멸자 호출");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("1==========================");
        Car aCar = new Car("BMW");
        new Car();

        Console.WriteLine("2==========================");

        // 함수활용
        aCar.Print();
        aCar.SetName("벤츠");
        aCar.Print();
        string name = aCar.GetName();
        Console.WriteLine("읽어온 값은 : " + name);

        Console.WriteLine("3==========================");

        // 프로퍼티
        aCar.name = "람보르기니";
        name = aCar.name;
        aCar.Print();
        Console.WriteLine("읽어온 값은 : " + name);

        Console.WriteLine("4==========================");
    }
}