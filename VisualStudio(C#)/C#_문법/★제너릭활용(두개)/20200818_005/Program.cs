using System;

class Program
{
    static void TwoPrint<T1, T2>(T1 Arg1, T2 Arg2) //T1, T2 : ,로 구분을 지어줌.
    {
        Console.WriteLine(Arg1);
        Console.WriteLine(Arg2);
    }

    static void Main(string[] args)
    {
        TwoPrint(3, 2.1);
        TwoPrint("헬로", 6.1f);
    }
}

