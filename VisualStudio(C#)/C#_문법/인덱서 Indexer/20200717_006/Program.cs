using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200717_006
{
    public class TestInt
    {
        private int[] _Array = new int[5];
        public int this[int index] // 인덱서 Indexer
        {
            get { return _Array[index]; }
            set { _Array[index] = value; }
        }
    }
    public class IndexerTest
    {
        private Hashtable myFavorite = new Hashtable();
        public string this[string kind]
        {
            get { return (string)myFavorite[kind]; }
            set { myFavorite[kind] = value; }
        }
    public class Test
        {
            private string[] _array = new string[5];
            public string this[int index]
            {
                get { return _array[index]; }
                set { _array[index] = value; }
            }

            static void Main(string[] args)
            {
                IndexerTest it = new IndexerTest();
                it["fruit"] = "apple";
                it["color"] = "blue";
                Console.WriteLine(it["fruit"]);
                Console.WriteLine(it["color"]);

                Test atest = new Test();
                atest[0] = "할룽A "; // 인덱서를 활용해서 배열 사용 가능
                atest[1] = "할룽B ";
                atest[2] = "할룽C ";
                atest[3] = "할룽D ";
                atest[4] = "할룽E ";
                Console.WriteLine(atest[2]);

                TestInt testInt = new TestInt();
                testInt[0] = 100;
                testInt[1] = 200;
                testInt[2] = 300;
                testInt[3] = 400;
                testInt[4] = 500;
                Console.WriteLine(testInt[4]);
            }
        }
    }
}
