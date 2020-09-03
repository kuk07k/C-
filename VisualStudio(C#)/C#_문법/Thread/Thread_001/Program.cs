using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 서버를 Thread로 돌림
            //Thread thread = Thread.CurrentThread;
            //Console.WriteLine(thread.ThreadState);

            //Console.WriteLine(DateTime.Now);
            //Thread.Sleep(1000); // 1초동안 스레드중지
            //Console.WriteLine(DateTime.Now);

            Thread t1 = new Thread(threadFunc1);
            Thread t2 = new Thread(threadFunc2);
            Thread t3 = new Thread(threadFunc3);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main 스레드 종료!");
        }

        static void threadFunc1()
        {
            Console.WriteLine("10초 후에 프로그램 종료");
            Thread.Sleep(1000 * 10); // 1000 == 1초 // 10초 동안 실행 중지 // 현재 주 스레드는 종료되었어도, t 스레드는 종속
            Console.WriteLine("10 스레드 종료!");
        }
        static void threadFunc2()
        {
            Console.WriteLine("5초 후에 프로그램 종료");
            Thread.Sleep(1000 * 5); 
            Console.WriteLine("5 스레드 종료!");
        }
        static void threadFunc3()
        {
            Console.WriteLine("2초 후에 프로그램 종료");
            Thread.Sleep(1000 * 2); 
            Console.WriteLine("2 스레드 종료!");
        }
    }
}
