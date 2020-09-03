using System;

namespace _20200715_002
{
    class Parent
    {
        public int iNum;

        public Parent(int iNum)
        {
            this.iNum = iNum;
            Console.WriteLine("Parent 클래스 생성자");
        }
        ~Parent()
        {
            Console.WriteLine("Parent 클래스 소멸자");
        }
    }
    class Child : Parent // class 자식 : 부모
    {
        public int iNum;

        public Child() : base(125) //부모의 생성자를 가져옴
        {
            iNum = 200;
            Console.WriteLine("Child 클래스 생성자");
        }

        public void Print()
        {
            Console.WriteLine("Parent 클래스 [ iNum = {0} ]", base.iNum);
            Console.WriteLine("Child 클래스 [ iNum = {0} ]", this.iNum);
        }
        ~Child()
        {
            Console.WriteLine("Child 클래스 소멸자");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child aChild = new Child();
            aChild.Print();
        }
    }
}
