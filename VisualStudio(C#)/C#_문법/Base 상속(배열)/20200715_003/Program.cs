using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200715_003
{
    class Parent
    {
        public virtual void Name()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public override void Name()
        {
            Console.WriteLine("Child");
        }
    }
    class GrandChild : Child
    {
        public override void Name()
        {
            Console.WriteLine("GrandChild");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Parent obj1 = new Parent(); // 객채참조변수의 타입에 의해 결정
            //Child obj2 = new Child();
            //GrandChild obj3 = new GrandChild();

            //obj1.Name();
            //obj2.Name();
            //obj3.Name();

            Parent[] Array = new Parent[] { new Parent(),
                                            new Child(),
                                            new GrandChild()
                                          };

            for(int i = 0; i < Array.Length; ++i)
            {
                Array[i].Name();
            }
           
        }
    }
}
