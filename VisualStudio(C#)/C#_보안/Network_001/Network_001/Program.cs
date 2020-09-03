using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Network_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPAddress ipAddr = IPAddress.Parse("192.168.0.160");
            //Console.WriteLine(ipAddr);

            //IPAddress ipAddr2 = new IPAddress(new byte[] { 192, 168, 0, 160 });
            //Console.WriteLine(ipAddr2);

            //IPAddress ipAddr3 = IPAddress.Parse("192.168.0.160");
            //IPEndPoint endpoint = new IPEndPoint(ipAddr3, 9000);
            //Console.WriteLine(endpoint);

            //IPHostEntry entry = Dns.GetHostEntry("www.naver.com");
            //foreach (IPAddress iPAddress in entry.AddressList)
            //{
            //    Console.WriteLine(iPAddress);
            //}

            string myComputer = Dns.GetHostName();

            Console.WriteLine("컴퓨터 이름: " + myComputer);

            IPHostEntry entry1 = Dns.GetHostEntry(myComputer);
            foreach (IPAddress iPAddress1 in entry1.AddressList)
            {
                Console.WriteLine(iPAddress1.AddressFamily + ": " + iPAddress1);
            }
        }
    }
}
