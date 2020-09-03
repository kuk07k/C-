using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자동차에 대해 속성과 행위를 생각해라

class Car
{
    private const int SpeedValue = 10; //const를 활용하여 내부 접근못하게
    private const int SpeedLimit = 200; // 속성을 추가    

    //속성(attribute)
    private int Speed;  //속도 : 숫자 => int형
    
    //행위(behavior) : 메소드
    public void Run ()
    {
        Console.WriteLine("작동합니다.");
    }

    public void Accel()
    {
        Speed = Speed + SpeedValue;

        if (Speed >= SpeedLimit)
        {
            Speed = SpeedLimit;
        }
        Console.WriteLine("현재속도는 {0}입니다.",Speed);
    }

    public void Break()
    {
        Speed = Speed - SpeedValue;

        if (Speed < 0)
        {
            Speed = 0;
        }
        Console.WriteLine("현재속도는 {0}입니다.", Speed);
    }
}

class Auto
{
    static void Main(string[] args)
    {
        Car aCar = new Car();
        aCar.Accel();
        aCar.Accel();
        aCar.Accel();

        aCar.Break();
        aCar.Break();
        aCar.Break();
        aCar.Break();
    }

    //static void Main1(string[] args)
    //{
    //    Car aCar = new Car();
    //    aCar.Run();
    //    aCar.Speed = 100;
    //    Console.WriteLine("aCar의 속도 : {0}", aCar.Speed);
    //    aCar.Accel();
    //    aCar.Break();
    //}
}