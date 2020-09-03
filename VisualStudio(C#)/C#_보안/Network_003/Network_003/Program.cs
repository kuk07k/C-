using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1");
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Console.WriteLine("2");
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        Console.WriteLine("3");
        Console.ReadLine();
        Console.WriteLine("4");

        Server.Close();
    }
}