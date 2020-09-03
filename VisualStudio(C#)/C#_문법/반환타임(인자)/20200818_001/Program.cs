using System;
using System.Collections;

class Program
{
    static void ArrayDoublePrint(double[] num1)
    {
        Console.WriteLine("Double형");
        for (int i = 0; i < num1.Length; i++)
        {
            Console.WriteLine(num1[i]);
        }
        Console.WriteLine();
    }

    static void ArrayStringPrint(string[] num1)
    {
        Console.WriteLine("String형");
        for (int i = 0; i < num1.Length; i++)
        {
            Console.WriteLine(num1[i]);
        }
        Console.WriteLine();
    }

    static void ArrayIntPrint(int [] num1)
    {
        Console.WriteLine("Int형");
        for (int i = 0; i < num1.Length; i++)
        {
            Console.WriteLine(num1[i]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args) // 반환타임(인자) , 데이터타입이 존재안할시 void
    {
        int[] Numbers1 = { 1, 3, 5, 7, 9 };

        ArrayIntPrint(Numbers1);

        double[] Numbers2 = { 1.1, 3.1, 5.2, 7.5, 9.4 };

        ArrayDoublePrint(Numbers2);

        string[] Numbers3 = { "일", "이", "삼", "사", "오" };

        ArrayStringPrint(Numbers3);
    }
}
