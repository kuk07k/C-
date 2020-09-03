using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200626_001
{
    class ObjectMethod
    {
        static void Main(String[] args) //C#은 전부 객체타입 //값타입, 참조타입
        {
            //double radius = 3.14;

            //Console.WriteLine("radius의 형 : {0}", radius.GetType()); //GetType을 활용하여 어떤 타입인지 확인가능
            //Console.WriteLine("radius의 값 : {0}", radius.ToString()); //기본적으로 ToString을 호출하기때문에 radius만 써서 출력가능
            //Console.WriteLine(); // Line은 줄을 바꾼다 // (\n)으로도 사용가능

            //string name = "이효리";

            //Console.WriteLine("name의 형 : {0}", name.GetType());
            //Console.WriteLine("name의 값 : {0}", name.ToString());
            //Console.WriteLine();

            //int Value = 3;
            //Console.WriteLine("int의 형 : {0}", Value.GetType());
            //Console.WriteLine("int의 값 : {0}", Value.ToString());
            //Console.WriteLine();

            //Console.WriteLine("radius == name : {0}", name.Equals(radius)); // equals : 두 값을 비교


            //----------------암시적 형변환--------------------//
            //직접 캐스팅하지 않고도 형의 변환이 일어남

            int intValue = 127;
            long longValue = intValue;

            Console.WriteLine("longValue = {0}", longValue);


            //----------------명시적 형변환--------------------//
            //명시적으로 직접 캐스팅하여 형의 변환이 일어남

            long longValue1 = 32767;
            int intValue1 = (int)longValue1;

            Console.WriteLine("intValue = {0}", intValue1);
        }
    }
}
