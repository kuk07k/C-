using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //===================== 서버의 흐름도 =====================//

        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // 소켓 자원생성 // TCP소켓 
        // Bind == IP, port를 합쳐서 Socket으로 넣는 것 (주소 : IP,  포트 : 특정번호를 찾음)
        // IPAddress.Any : 자동으로 자신의 IP를 넣어줌
        // 세팅하는과정 : IP의 주소와 TCP의 포트번호 설정
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000)); //Server.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.110"), 7000)); // 포트번호 7000으로 묶임
        Server.Listen(100); // 접속허용 // ()는 최대 클라이언트 접속갯수  // 입구넓이 // 대기전용 - 통신이 가능하지 않음

        Socket Client = Server.Accept(); // blocking 메소드 (프로그램을 잠시 막아둠) // accept : 접속을 하나씩 허용한다
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[1024]; 
        int Number = Client.Receive(Buffer);
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Number)); //cw Tab Tab
        Buffer = Encoding.UTF8.GetBytes("서버에서 보냅니다... 받아주세요 !!");
        Client.Send(Buffer); // 우리쪽에서 다른쪽에 데이터 보낼때 사용 (Send)

        Client.Close();
        Server.Close();
    }
}