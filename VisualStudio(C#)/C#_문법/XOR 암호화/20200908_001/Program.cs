using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200908_001
{
    class Program
    {
        /// <summary>
        /// XOR 암호화
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string PlainText = "할룽";
            char[] PlainTextArray = PlainText.ToCharArray(); // 문자를 암호화하기위해 쪼갬(두글자로)
            string CyperText;
            char[] CyperTextArray;
            char Key = (char)0x0908;

            // XOR 암호화 작업
            CyperTextArray = new char[PlainTextArray.Length]; // PlainTextArray가 두개짜리기 때문에 CyperTextArray도 두개로 쪼개짐
            CyperTextArray[0] = (char)(PlainTextArray[0] ^ Key); // ^ : XOR
            CyperTextArray[1] = (char)(PlainTextArray[1] ^ Key);

            CyperText = CyperTextArray.ToString();

            Console.WriteLine("PlainText : {0}{1}", PlainTextArray[0], PlainTextArray[1]);
            Console.WriteLine("CyperText : {0}{1}", CyperTextArray[0], CyperTextArray[1]);

            // 암호화된 코드 복구하기
            char[] PlainTextArray2 = new char[CyperTextArray.Length]; // 2에 CyperTextArray 길이만큼 만듬 (2개)
            PlainTextArray2[0] = (char)(CyperTextArray[0] ^ Key);
            PlainTextArray2[1] = (char)(CyperTextArray[1] ^ Key);

            Console.WriteLine("PlainTextArray2 : {0}{1}", PlainTextArray2[0], PlainTextArray2[1]);
        }
    }
}
