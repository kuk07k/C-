using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200716_003
{
    // 추상메소드만 보유 가능한 interface // 가이드기능 // 목차기능

    interface IMusician // 인터페이스에는 I붙이기
    {
        void Singing();
    }
    interface IActor
    {
        void Playing();
    }
    class Musical : IMusician, IActor
    {
        public void Singing()
        {
            Console.WriteLine("노래하다.");
        }
        public void Playing()
        {
            Console.WriteLine("연기하다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Musical musical = new Musical();
            musical.Singing();
            musical.Playing();
        }
    }
}
