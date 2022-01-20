using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _02_Socket编程_UDP协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Socket
            Socket udpClient=new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);

            //发送数据
            while (true)
            {
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7788);   //指定发送到的服务器端的ip和端口号
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);
            }
           

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
