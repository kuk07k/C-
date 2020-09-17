using System;

class Program
{
    delegate int Facto(int i1, int i2);
    class MessageMap
    {
        public string cmd { get; set; }
        public Facto Method { get; set; }

        public MessageMap()
        {
        }
        public MessageMap(string _cmd, Facto _Method)
        {
            cmd = _cmd;
            Method = _Method;
        }
    }

    static public int add(int T1, int T2)
    {
        return T1 + T2;
    }
    static public int mul(int T1, int T2)
    {
        return T1 * T2;
    }
    static public int sub(int T1, int T2)
    {
        return T1 - T2;
    }
    static public int div(int T1, int T2)
    {
        return T1 / T2;
    }

    static int step1(string command, int iNum1, int iNum2)
    {
        switch (command)
        {
            case "더하기":
                return add(iNum1, iNum2);
            case "빼기":
                return sub(iNum1, iNum2);
            case "곱하기":
                return mul(iNum1, iNum2);
            case "나누기":
                return div(iNum1, iNum2);
            default:
                return 0;
        }
    }

    static int step2(string command, int iNum1, int iNum2)
    {
        Facto aFacto;
        switch (command)
        {
            case "더하기":
                aFacto = add;
                break;
            case "빼기":
                aFacto = sub;
                break;
            case "곱하기":
                aFacto = mul;
                break;
            case "나누기":
                aFacto = div;
                break;
            default:
                return 0;
        }

        return aFacto(iNum1, iNum2);
    }

    static int step3(string command, int iNum1, int iNum2)
    {
        MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap() { cmd = "더하기", Method = add },
            new MessageMap() { cmd = "빼기", Method = sub },
            new MessageMap() { cmd = "곱하기", Method = mul },
            new MessageMap() { cmd = "나누기", Method = div }
        };

        foreach (MessageMap Temp in aMessageMap)
        {

            if (Temp.cmd.Equals(command))
            {
                return Temp.Method(iNum1, iNum2);
            }
        }

        return 0;

    }

    static int step4(string command, int iNum1, int iNum2)
    {
        MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap("더하기", add),
            new MessageMap("빼기", sub),
            new MessageMap("곱하기", mul),
            new MessageMap("나누기", div)
        };

        foreach (MessageMap Temp in aMessageMap)
        {

            if (Temp.cmd.Equals(command))
            {
                return Temp.Method(iNum1, iNum2);
            }
        }

        return 0;

    }

    static void Main(string[] args)
    {
        Console.Write("정수1을 입력하세요 : ");
        int iNum1 = Int32.Parse(Console.ReadLine());
        Console.Write("정수2를 입력하세요 : ");
        int iNum2 = Int32.Parse(Console.ReadLine());

        MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap("더하기", add),
            new MessageMap("빼기", sub),
            new MessageMap("곱하기", mul),
            new MessageMap("나누기", div)
        };
        string command;
        bool bingo = false;
        while (true)
        {
            Console.Write("수행할 연산을 한글로 입력하세요(도움말 : ?) ");
            command = Console.ReadLine();

            if (null == command)
            {
                Console.WriteLine("잘 못 입력하셨습니다");
                continue;
            }

            if ('?' == command[0])
            {
                Console.WriteLine("사용할 수 있는 연산 리스트");
                Console.WriteLine("============================");
                foreach (MessageMap Temp in aMessageMap)
                {
                    Console.WriteLine(Temp.cmd);
                }
                Console.WriteLine("============================");
                continue;
            }

            foreach (MessageMap Temp in aMessageMap)
            {
                if (Temp.cmd.Equals(command))
                {
                    bingo = true;
                }
            }

            if (false == bingo)
            {
                Console.WriteLine("잘 못 입력하셨습니다");
                continue;
            }

            break;
        }

        int Result = step4(command, iNum1, iNum2);
        Console.WriteLine(command + $"의 결과는 {Result}입니다.");
    }
}
