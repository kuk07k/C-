using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200701_004
{
    class Program
    {
        //===============메소드 오버로딩=====================//
        //Add라는 메소드는 오버로딩되어있다
        //인자값으로 구분가능한 메소드
        //이름이 값아서 인자값이 다르면 가능
        //메소드를 호출할때 인자가 명확해야함 , 인자가 기준이 되기때문에

        static int Add(int inum1, int inum2)
        {
            int inum3 = inum1 + inum2;

            return inum3;
        }

        static float Add(float inum1, float inum2)
        {
            float inum3 = inum1 + inum2;

            return inum3;
        }

        static double Add(double inum1, double inum2)
        {
            double inum3 = inum1 + inum2;

            return inum3;
        }




        static int AddInt(int inum1, int inum2)
        {
            int inum3 = inum1 + inum2;

            return inum3;
        }

        static float AddFloat(float num1, float num2)
        {
            float num3 = num1 + num2;

            return num3;
        }

        static double Adddouble(double num11, double num22)
        {
            double num33 = num11 + num22;

            return num33;
        }



        static void Main(string[] args)
        {
            int Num1 = 3;
            int Num2 = 4;
            int Num3 = Num1 + Num2;
            Console.WriteLine("{0} + {1} = {2}",Num1, Num2, Num3);

            int inum4 = AddInt(5, 6);
            Console.WriteLine("{0} + {1} = {2} ", 5, 6, inum4);
            float fnum3 = AddFloat(5.1f, 6.1f);
            Console.WriteLine("{0} + {1} = {2} ", 5.1f, 6.1f, fnum3);
            double dnum4 = Adddouble(5.1, 6.1);
            Console.WriteLine("{0} + {1} = {2} ", 5.1, 6.1, dnum4);
        }
    }
}
