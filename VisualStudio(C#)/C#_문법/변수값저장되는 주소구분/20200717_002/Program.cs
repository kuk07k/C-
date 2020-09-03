using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200717_002
{
    class Coordinate
    {
        public int x;
        public int y;
    }
    class Program
    {
        static Coordinate test()
        {
            Coordinate temp = new Coordinate();
            return temp;
        }


        static void Main(string[] args)
        { 
            Coordinate c1 = new Coordinate();
            Coordinate c2 = new Coordinate();

            c1.x = 1;
            c1.y = 2;
            c2.x = 1;
            c2.y = 2;

            Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
            Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);

            if (c1 == c2)
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다"); // 주소가 다르기때문에 다르다
            }
        }




        static void Main1(string[] args)
        {
            Coordinate c = test();
            c.x = 1;
            c.y = 2;
            Console.WriteLine("c = {0}, {1}", c.x, c.y);
            c = null;
            
            try
            {
                c.x = 1;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException 예외 처리입니다.");
            }
        }
    }
}
