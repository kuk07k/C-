using System;

class Engin
{
    string name;
    string vender;

    public Engin()
    {
        name = "휘발류 V6";
        vender = "비엔츠";
    }

    public override string ToString()
    {
        string Temp = "["
                        + "{" + name + "},"
                        + "{" + vender + "}"
                        + "]";

        return Temp;
    }
}
class Car
{
    string color;
    string name;
    string vender;
    Engin aEngin;

    public Car()
    {
        color = "하양";
        name = "자동차";
        vender = "람보르니";
        aEngin = new Engin();
    }

    public override string ToString()
    {
        string Temp = "["
                        + "{" + color + "},"
                        + "{" + name + "},"
                        + "{" + vender + "}"
                        + "{" + aEngin + "}"
                        + "]";

        return Temp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car aCar = new Car();
        //Console.WriteLine(aCar.Equals("test"));
        //Console.WriteLine(aCar.GetHashCode());
        Console.WriteLine(aCar.GetType());
        Console.WriteLine(aCar.ToString());
        Console.WriteLine(aCar);
    }
}