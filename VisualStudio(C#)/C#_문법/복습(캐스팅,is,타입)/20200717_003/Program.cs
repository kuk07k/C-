using System;

    class Vehicle { }
    class Car : Vehicle { }

    class Program
    {
        static void Main1(string[] args)
        {
            //Car vehicle = new Car();
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            try
            {
                car = (Car)vehicle;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("예외처리");
            }
        }

        static void main2(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            Vehicle a = car;
            Car b = (Car)a; // 명시적 형변환 (강제적형변환)
        }

        static void Main3(string[] args)
        {
            Vehicle[] array = new Vehicle[] { new Vehicle(), new Car(), new Vehicle() };
            foreach (Vehicle item in array)
            {
                Console.WriteLine(item);
            } 
        }

        static void Main4(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();

            if (vehicle is Car) // 오른쪽 왼쪽 비교 (참,거짓)
            {
                car = (Car)vehicle;
            }
            else
            {
                Console.WriteLine("Vehicle은 Car가 아니다");
            }
        }

        static void Main5(string[] args)
        {
            Vehicle vehicle = new Car();
            Car acar = new Car();

            acar = vehicle as Car; 
            // A as B : A가 B를 보유하고 있는지
            // 명시적 캐스팅보다 as 가 더 좋음 !
            
            if(acar == null)
            {
                Console.WriteLine("널 보내줄게");
            }
            else
            {
                Console.WriteLine(acar);
            }
        }

        static void Main(string[] args)
        {
        Object[] aObjcet = new Object[] { new Vehicle(),
                                          new Car(),
                                          new Vehicle(),
                                          new Car(),
                                          new Vehicle(),
                                          new Car(),
                                         };
        Car acar;
        for(int i = 0; i < aObjcet.Length; ++i)
        {
            acar = aObjcet[i] as Car;

           
            if ((acar = aObjcet[i] as Car) == null) //카 객체가 aObject에 있는 경우는
                                                    //aCar = aObject[i]
                                                    //카 객체가 aObject에 없는 경우는
                                                    //aCar = null
            {
                //acar가 Vehicle 객체인 경우
                Vehicle vehicle = (Vehicle)aObjcet[i];
                Console.WriteLine("Vehicle 타입");
            }
            else
            {
                //acar가 Car 객체인 경우
                Console.WriteLine("Car  타입");
            }
        }
    }
}

