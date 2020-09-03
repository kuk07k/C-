using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220200717_001
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***************************************** //
            // ************* 값 입력받고 저장 ********** //
            // ***************************************** //
            int Num1;
            int Num2;
            double Num3;

            //Console.Write("첫번째로 입력할 숫자 : ");
            //Num1 = int.Parse(Console.ReadLine());

            //Console.Write("두번째로 입력할 숫자 : ");
            //Num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Num1);
            //Console.WriteLine(Num2);


            // ***************************************** //
            // ************* Try, Catch 문 ************* //
            // ***************************************** //
            // : 좋은 프로그램은 예외를 틀어막음
            // : 모든 상황에 대비하는 기능
            // : 에러 처리 전용
            // try,catch는 무조건 한번이상 사용
            // throw,finally는 마음대로 사용

            // ************* if, else 문 *************
            // : 프로그램 논리를 바꿈

            while (true)
            {
                try
                {
                    Console.Write("첫번째로 입력할 숫자 : ");
                    Num1 = int.Parse(Console.ReadLine());
                    if (Num1 < 0 ) // 특정조건일때 throw를 사용 (try안에 사용 !)
                    {
                        Exception exception = new Exception();
                        throw exception;
                    }

                    Console.Write("두번째로 입력할 숫자 : ");
                    Num2 = int.Parse(Console.ReadLine());

                    Num3 = Num1 / Num2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("문자를 입력해서 발생");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("0으로 나눌 수 없음");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("음수를 입력해서 발생");
                    continue;
                }
                finally
                {
                    Console.WriteLine("이건 예외가 있던 없던 무조건 거쳐감");
                }
                break;
            }
        }
    }
}
