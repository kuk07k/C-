using System;
using System.Diagnostics;

delegate int CalcDelegate(int x, int y);
delegate void WorkDelegate(char arg1, int arg2, int arg3);

class MessageMap
{
    public char opCode;
    public CalcDelegate cal;
    
    public MessageMap(char opCode, CalcDelegate cal)
    {
        this.opCode = opCode;
        this.cal = cal;
    }
}

public class Mathematics
{
    MessageMap[] aMessageMap;

    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }
    static int Per(int x, int y) { return x % y; }

    public Mathematics() // 생성자
    {
        aMessageMap = new MessageMap[] {    new MessageMap('+', Add),
                                            new MessageMap('-', Sub),
                                            new MessageMap('*', Mul),
                                            new MessageMap('/', Div),
                                            new MessageMap('%', Per) };
    }

    // case 문을 여러개를 안쓰기 위해서 사용 !!
    public void Calculate(char opCode, int operand1, int oprand2)
    {
        Console.Write(opCode + " : ");
        foreach (MessageMap temp in aMessageMap)
        {
            if(temp.opCode == opCode)
            {
                Console.WriteLine(temp.cal(operand1, oprand2));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics mathematics = new Mathematics();
            WorkDelegate workDelegate = mathematics.Calculate;
            workDelegate('+', 10, 5);
            workDelegate('-', 10, 5);
            workDelegate('*', 10, 5);
            workDelegate('/', 10, 5);
            workDelegate('%', 10, 6);
        }
    }
}