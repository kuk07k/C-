using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20200909_003
{

    /// <summary>
    /// XML 데이터 가공
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            //Console.WriteLine(axElement);
            var XMLData = from Temp in axElement.Descendants("data") select Temp;
            foreach (var item in XMLData)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Element("hour").Value + "시\t");
                Console.WriteLine(item.Element("temp").Value+ "℃\t");
                Console.WriteLine(item.Element("wfKor").Value+ "\t");
                Console.WriteLine(item.Element("wdKor").Value+ "풍\t");
                Console.WriteLine();
            }
        }
    }
}
