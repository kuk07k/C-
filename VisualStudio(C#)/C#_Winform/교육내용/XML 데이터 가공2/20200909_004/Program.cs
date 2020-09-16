using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20200909_004
{

    /// <summary>
    /// XML 데이터 가공
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            XElement axElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2623052000");
            var XMLData = from Temp in axElement.Descendants("data")
                          select new Weather()
                          {
                              hour = Temp.Element("hour").Value,
                              temp = Temp.Element("temp").Value,
                              wfKor = Temp.Element("wfKor").Value,
                              wdKor = Temp.Element("wdKor").Value
                          };

            foreach (var item in XMLData)
            {
                Console.WriteLine(item);
            }

        }
    }
}