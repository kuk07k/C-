using System;

/*class FACT<T>
{
    public T Value;
    
    public void Print()
    {
        Console.WriteLine("FACT Value = {0}", Value); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        FACT<int> fact1 = new FACT<int>();
        fact1.Value = 100;
        fact1.Print();

        FACT<string> fact2 = new FACT<string>();
        fact2.Value = "팩트";
        fact2.Print();
    }
}*/

class FACT<T1, T2>
{
    public T1 Value1;
    public T2 Value2;

    public void Print()
    {
        Console.WriteLine("FACT Value = {0} : {1}", Value1, Value2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FACT<int, string> fact1 = new FACT<int, string>();
        fact1.Value1 = 100;
        fact1.Value2 = "팩트";
        fact1.Print();
    }
}
