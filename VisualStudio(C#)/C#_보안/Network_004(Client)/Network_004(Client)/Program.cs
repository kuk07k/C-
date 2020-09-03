using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Network_004
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient atcpClient = new TcpClient("192.168.0.110", 7000);
            Console.WriteLine("서버에 접속합니다 !!!");

            NetworkStream anetworkStream = atcpClient.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes("♥♥♥ HAPPY DAY ♥♥♥");
            anetworkStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine("서버로 전송한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            buffer = new byte[1024];
            int BufferCount = anetworkStream.Read(buffer, 0, buffer.Length); // offset : 범위(0 ~)
            Console.WriteLine("서버가 전송한 Data 크기 : " + BufferCount);
            Console.WriteLine("서버가 전송한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            Console.WriteLine("클라이언트를 종료합니다...");
            anetworkStream.Close();
            atcpClient.Close();
        }
    }
}