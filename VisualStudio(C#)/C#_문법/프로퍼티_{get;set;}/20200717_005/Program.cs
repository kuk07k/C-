using System;
using System.Xml.Schema;

namespace PropertySample1
{
    public class PropertyTest
    {
        private string _name; // 읽고 쓰기
        private int _Readonly; // 읽기만
        private int _Writeonly; // 쓰기만
        private static int _static;

        public static int Static
        {
            get { return _static; }
            set { _static = value; }
        }

        public int Writeonly //(set : 쓰기만)
        {
            set { _Writeonly = value; }
        }

        public int Readonly //(get : 읽기만)
        {
            get { return _Readonly; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
            PropertyTest pt = new PropertyTest();
            pt.Name = "헬로 키티";
            //pt.Readonly = 3; // 읽기만 가능, 쓰기는 에러
            

            Console.WriteLine(pt.Name);
            Console.WriteLine(pt.Readonly);
            //Console.WriteLine(pt.Writeonly); //쓰기만 가능, 읽기는 에러
            PropertyTest.Static = 200;
            Console.WriteLine(PropertyTest.Static);
        }
    }
}
