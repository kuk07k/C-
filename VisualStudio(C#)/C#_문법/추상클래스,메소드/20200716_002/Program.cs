using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200716_002
{
    abstract class Musician// 추상클래스
    {
        public virtual void Name()
        {
            Console.WriteLine("Musician");
        }
        public abstract void Instruments(); // 추상메소드
    }
    class ViolinPlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("ViolinPlayer");
        }
        public override void Instruments()
        {
            Console.WriteLine("Violin");
        }
    }
    class PianoPlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("PianoPlayer");
        }
        public override void Instruments()
        {
            Console.WriteLine("Piano");
        }
    }
    // [ abstract를 활용한 부모의 클래스 ]를 가져와 쓰려면 
    // 자식 클래스에서 추상메소드를 다 사용하여야 한다
    class FlutePlayer : Musician
    {
        public override void Name()
        {
            Console.WriteLine("FlutePlayer");
        }
        public override void Instruments()
        {
            Console.WriteLine("Flute");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Musician[] Array = new Musician[3];
            Array[0] = new ViolinPlayer();
            Array[1] = new PianoPlayer();
            Array[2] = new FlutePlayer();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i].Name();
                Array[i].Instruments();
                Console.WriteLine("=================");
            }
        }
    }
}
