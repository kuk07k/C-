using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_004_try_catch문
{
    class Program
    {
        static int Main(string[] args)
        {
            int a, b;
            float c = 0;
        

            try // 여기서 에러가 발생하는지 찾겠다 // 실행될때 일어나는 에러
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
            }
            // Catch 여러개 가능
            // catch 문의 인자부분이 달라야한다 
            // Try에서 문제 발생시
            catch (FormatException) 
            {
                Console.WriteLine("문자를 입력하셨습니다.");
                Environment.Exit(0);
            }

            // 에러가 발생했을시 여기로 점프 
            // Exception : Error : 예외(런타임 에러)
            // Exit : 프로그램 종료 (그 위치에서 종료)
            catch (DivideByZeroException) 
            {
               
                Console.WriteLine("변수의 값이 올바르지 않습니다.");
                Environment.Exit(0);
            }
            // 에러가 발생하지 않을시 여기로 점프 (생략가능)
            // catch문갔다가도 실행 
            // 그렇기때문에 catch문에서 exit 실행
            finally
            {
                Console.WriteLine("프로그램이 실행 되었습니다.");
            }
            Console.WriteLine("A/B값은 {0}입니다.", c);

            return 0;
            // void main일땐 return 사용 X
            // 0 == 정상종료
            // 다른것은 비정상종료 || 사용자가 지정해서 사용(1 == 입력오류)
        }
    }
}
