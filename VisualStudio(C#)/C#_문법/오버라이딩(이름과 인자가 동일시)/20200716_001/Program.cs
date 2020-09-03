using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200716_001
{
    class Mammal
    {
        public virtual void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }
    class Human : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
    class Program
    {   
        //오버라이딩 : 이름과 인자가 동일
        //오버로딩 : 인자가 다를때

        static void Main(string[] args)
        {

            Mammal[] mammals = new Mammal[4] {new Mammal(),
                                              new Lion(),
                                              new Whale(),
                                              new Human()};
            foreach (Mammal item in mammals)
            {
                item.Move();
            }


        }
    }
}
