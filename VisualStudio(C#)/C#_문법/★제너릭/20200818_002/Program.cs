using System;

class Program
{
    // 템플릿 (제너릭 프로그램) : 메소드에 적용
    // 타입을 제외하고 중복이 일어나는 코드 
    // 타입때문에 메소드를 여러개만들어야해서 비효율적임
    // 타입에 따라 변신하도록
    // 바꿔줘야하는 부분을 컴파일러에게 맡김(시간절약) 
    // Name<T>(변수) : 문법

    static void ArrayPrint<T>(T[] num1) 
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
        double[] Numbers2 = { 1.1, 3.1, 5.2, 7.5, 9.4 };
        string[] Numbers3 = { "일", "이", "삼", "사", "오" };

        ArrayPrint<int>(Numbers1);
        ArrayPrint<double>(Numbers2);
        ArrayPrint<string>(Numbers3);
    }
}
