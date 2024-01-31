// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        const int port = 5000;

        TcpListener listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        Console.WriteLine($"Listening on port {port}...");

        while (true)
        {
            using (TcpClient client = listener.AcceptTcpClient())
            {
                Console.WriteLine("Client connected");

                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes("Hello, docker!\n");
                    stream.Write(data, 0, data.Length);
                }
            }
        }
    }
}
