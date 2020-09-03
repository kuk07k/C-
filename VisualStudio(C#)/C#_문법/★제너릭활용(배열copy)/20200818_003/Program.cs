using System;

class Program
{
    static void ArrayIntCopy(int[] Dst, int[] Src)
    {
        for (int i = 0; i < Dst.Length; i++)
        {
            Dst[i] = Src[i];
        }
    }

    static void ArrayDoubleCopy(double[] Dst, double[] Src)
    {
        for (int i = 0; i < Dst.Length; i++)
        {
            Dst[i] = Src[i];
        }
    }

    static void ArrayPrint<T>(T[] num1)
    {
        Console.WriteLine("================");
        for (int i = 0; i < num1.Length; i++)
        {
            Console.WriteLine(num1[i]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] ArrayInt1 = { 2, 4, 6, 8 };
        int[] ArrayInt2 = new int[4];
        ArrayIntCopy(ArrayInt2, ArrayInt1);
        ArrayPrint<int>(ArrayInt2);

        double[] Arraydouble1 = { 2.1, 4.5, 6.6, 8.7 };
        double[] Arraydouble2 = new double[4];
        ArrayDoubleCopy(Arraydouble2, Arraydouble1);
        ArrayPrint<double>(Arraydouble2);
    }
}
