using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915_004
{
    /// <summary>
    /// ======================     델리게이트 (Delegate) : 메소드 이름을 저장하는 DataType     ======================
    /// 메소드의 반환값, 인자의 개수 및 타입을 메소드의 인터페이스 혹은 시그니쳐
    /// 메소드를 개발자가 만들면 상황에 따라 반환값과 인자의 개수, 인자의 타입이 다 다르다
    /// 그러므로 한가지 모양의 델리게이트를 정의할 수 없기 때문에 개발자가 델리게이트 즉, 메소드를 저장하는 자료형을 직접 만들어 줘야 한다
    /// 그래서 c#은 델리게이트 키워드만 제공하고 개발자는 이 키워드를 이용하여 델리게이트 자료형을 직접 만들어 사용한다
    /// C++ , C의 포인터 개념 
    /// </summary>


    class Program
    {
        static int MulInt(int temp1, int temp2)
        {
            return temp1 * temp2;
        }

        static int addInt(int num1, int num2) // 메소드의 인터페이스 // API : 인터페이스(함수)를 이용한 앱
        {
            return num1 + num2;
        }

        // 위 메소드의 이름을 저장할 수 있는 자료형을 생성하려면 일단 Delegate라는 키워드를 먼저 코딩한다.
        // 이후 메소드의 인터페이스 부분을 그대로 적는다.
        // 여기서 메소드의 이름인 addInt를 개발자 마음대로 바꾸어 준다.
        // 이 바꾸어진 이름이 새로운 data type이 된다.
        // 제일 끝에 세미콜론을 추가 함으로 인해 새로운 data type인 Facto type을 완성한다
        // 따라서 Facto 는 변수형 delegate , addInt는 상수형 delegate
        delegate int Facto(int num1, int num2);

        static void Main(string[] args)
        {
            int sum = addInt(3, 4);
            Console.WriteLine(sum);

            Facto afacto;
            afacto = addInt; // aFacto = addInt; == 같은 자료형이라는 것이다.
            sum = afacto(3, 4);
            Console.WriteLine(sum);

            afacto = MulInt;
            sum = afacto(3, 4);
            Console.WriteLine(sum);
        }
    }
}
