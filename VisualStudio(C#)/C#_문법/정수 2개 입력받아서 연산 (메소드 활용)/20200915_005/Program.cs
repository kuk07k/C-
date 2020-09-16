using System;

namespace _20200915_005
{
    class Program
    {

        // int형 반수 Result와 switch case문을 사용하여 프로그램을 완성하시오

        static public int Add(int t1, int t2)
        {
            return t1 + t2;
        }
        static public int mul(int t1, int t2)
        {
            return t1 * t2;
        }
        static public int sub(int t1, int t2)
        {
            return t1 - t2;
        }
        static public int div(int t1, int t2)
        {
            return t1 / t2;
        }


        static int step1(string command, int iNum1, int iNum2)
        {
            switch (command)
            {
                case "더하기":
                    {
                        return Add(iNum1, iNum2);
                    }
                case "빼기":
                    {
                        return sub(iNum1, iNum2);
                    }
                case "곱하기":
                    {
                        return mul(iNum1, iNum2);
                    }
                case "나누기":
                    {
                        return div(iNum1, iNum2);
                    }
                default:
                    return 0;
            }
        }

        delegate int Facto(int t1, int t2);

        class Messagemap
        {
            public string cmd { get; set; }
            public Facto Method { get; set; }
        }

        static int step3(string command, int iNum1, int iNum2)
        {
            Messagemap[] amessagemap = new Messagemap[] {
                                                            new Messagemap() { cmd = "더하기", Method = Add },
                                                            new Messagemap() { cmd = "빼기", Method = sub},
                                                            new Messagemap() { cmd = "곱하기", Method = mul },
                                                            new Messagemap() { cmd = "나누기", Method = div }
                                                         };

            foreach (Messagemap temp in amessagemap)
            {
                if (temp.cmd.Equals(command)) // cmd와 method가 같은지 비교
                {
                    return temp.Method(iNum1, iNum2);
                }
            }
            return 0;
        }
            
        static void Main(string[] args)
        {
            // 입력받는 구문
            Console.Write("정수1을 입력하세요 : ");
            int iNum1 = int.Parse(Console.ReadLine());
            Console.Write("정수2를 입력하세요 : ");
            int iNum2 = int.Parse(Console.ReadLine());
            Console.Write("수행할 연산을 한글로 입력하세요(더하기, 빼기, 곱하기, 나누기) : ");
            string command = Console.ReadLine();

            // 계산, 출력하는 구문
            int result = step3(command, iNum1, iNum2);
            Console.WriteLine(command + $"의 결과는 : {result} 입니다.");
        }
    }
}