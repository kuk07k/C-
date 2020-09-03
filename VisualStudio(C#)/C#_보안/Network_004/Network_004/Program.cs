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
            TcpListener atcplistener = new TcpListener(IPAddress.Any, 7000); //한줄로 Listen까지 생성
            atcplistener.Start();
            Console.WriteLine("서버가 시작되었습니다...");

            TcpClient atcpClient = atcplistener.AcceptTcpClient();
            Console.WriteLine("클라이언트가 접속되었습니다...");
            atcplistener.Stop();

            NetworkStream anetworkStream = atcpClient.GetStream();
            byte[] buffer = new byte [1024];
            int BufferCount = anetworkStream.Read(buffer, 0, buffer.Length); // offset : 범위(0 ~)
            Console.WriteLine("클라이언트가 전송한 Data 크기 : " + BufferCount);
            Console.WriteLine("클라이언트가 전송한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            buffer = Encoding.UTF8.GetBytes("♥♥♥ HAPPY DAY ♥♥♥");
            anetworkStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine("클라이언트로 회신한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            Console.WriteLine("서버를 종료합니다...");
            anetworkStream.Close();
            atcpClient.Close();
        }
    }
}
