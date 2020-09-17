using System;
class Program
{
    delegate int Facto(int i1, int i2);

    static MessageMap[] aMessageMap = new MessageMap[]
    {
        new MessageMap("더하기", add),
        new MessageMap("빼기", sub),
        new MessageMap("곱하기", mul),
        new MessageMap("나누기", div),
        new MessageMap("거듭제곱", squar)
    };

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

    static public int squar(int T1, int T2)
    {
        int temp = 1;

        while (0 != T2)
        {
            temp = temp * T1;
            --T2;
        }

        return temp;
    }

    static void CmdList()
    {
        Console.WriteLine("사용할 수 있는 연산 리스트");
        Console.WriteLine("============================");
        foreach (MessageMap Temp in aMessageMap)
        {
            Console.WriteLine(Temp.cmd);
        }
        Console.WriteLine("============================");
    }

    static Facto DelegateSearch(string command)
    {
        foreach (MessageMap Temp in aMessageMap)
        {
            if (Temp.cmd.Equals(command))
            {
                return Temp.Method;
            }
        }
        return null;
    }
    static int RunCacul(string command, int iNum1, int iNum2)
    {
        Facto aFacto = DelegateSearch(command);
        if (null == aFacto)
        {
            return 0;
        }
        return aFacto(iNum1, iNum2);
    }

    static string InputCmd()
    {
        string command;

        while (true)
        {
            Console.Write("수행할 연산을 한글로 입력하세요(도움말 : ?) ");
            command = Console.ReadLine();

            if ("" == command) // null 과 "" 구분하여 사용
            {
                Console.WriteLine("잘 못 입력하셨습니다");
                continue;
            }

            if ('?' == command[0])
            {
                CmdList();
                continue;
            }

            foreach (MessageMap Temp in aMessageMap)
            {
                if (Temp.cmd.Equals(command))
                {
                    return command;
                }
            }

            Console.WriteLine("잘 못 입력하셨습니다");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("정수1을 입력하세요 : ");
        int iNum1 = Int32.Parse(Console.ReadLine());
        Console.Write("정수2를 입력하세요 : ");
        int iNum2 = Int32.Parse(Console.ReadLine());

        string command = InputCmd();

        int Result = RunCacul(command, iNum1, iNum2);

        Console.WriteLine(command + $"의 결과는 {Result}입니다.");
    }
}