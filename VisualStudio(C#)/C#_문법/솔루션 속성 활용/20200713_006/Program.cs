using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] TTT)//arguments : args
        {
            /*Console.WriteLine(TTT.Length);
            Console.WriteLine(TTT[0]);
            Console.WriteLine(TTT[1]);*/
            if (0 == TTT.Length)
            {
                Console.WriteLine("그냥 열기");
            }
            else if (1 == TTT.Length)
            {
                Console.WriteLine("{0} 파일 이름으로 열기", TTT[0]);
            }
        }
    }
}
