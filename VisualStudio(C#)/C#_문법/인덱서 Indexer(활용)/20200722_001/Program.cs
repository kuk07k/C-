using System;

    //class TestInt
    //{
    //    private int[] _Array;

    //    public TestInt(int size)
    //    {
    //        _Array = new int[size];
    //    }

    //    public int this[int index] // 인덱서 Indexer
    //    {
    //        get { return _Array[index]; }
    //        set { _Array[index] = value; }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TestInt testInt1 = new TestInt(10);
    //    }
    //}



class Car
{
    public string name;
}

class TestCar
{
    private Car[] _Array = new Car[5];

    public Car this[int index]
    {
        get { return _Array[index]; }
        set { _Array[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestCar testCar = new TestCar();
        testCar[0] = new Car();
        testCar[1] = new Car();
        testCar[2] = new Car();
        testCar[0].name = "비오는 날에는 소시지빵";
        testCar[1].name = "게임은 폭력적이다";
        testCar[2].name = "우아아아아앙";
        Console.WriteLine(testCar[0].name);
    }
}

