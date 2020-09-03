using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200626_002
{
    class Program
    {
        static void Main(string[] args)
        {
            ////----- bool 연산자 -----//
            //// True || False 의 값만 담을 수 있다. // 7 < 6 과 같은 불린형 연산
            bool abool = 7 > 6;
            //bool abool2 = 7 < 6;
            //Console.WriteLine(abool);
            //Console.WriteLine(abool2);


            //int aint = 0x12345678;
            //Console.WriteLine("{0:X8}", aint);
            ////aint = ~aint; // ~ : NOT 연산 : REVERSE 시켜줌
            ////Console.WriteLine("{0:X8}", aint);
            //aint = aint >> 4;
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint << 4;
            //Console.WriteLine("{0:X8}", aint);

            //byte abyte1 = 0x3F;
            //byte abyte2 = 0xC1;

            //Console.WriteLine("AND {0:X2}", abyte1 & abyte2);
            //Console.WriteLine("OR  {0:X2}", abyte1 | abyte2);
            //Console.WriteLine("XOR {0:X2}", abyte1 ^ abyte2);

            //----- 삼항연산자 -----//
            // A ? B : C
            // (조건) ? 참 : 거짓

            Console.WriteLine("abool의 상태는 " + (abool ? "<참>" : "<거짓>") + "입니다.");
        }
    }
}
