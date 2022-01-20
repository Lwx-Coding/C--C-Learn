using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_socket编程_UDP协议_服务器端
{
    class Program
    {   //UDP是广播，不管你有没有连接，都在发送 TCP是只有连接了才能发送
        private static Socket udpServer;
        static void Main(string[] args)
        {
            //1.创建socket
             udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //2.绑定端口号跟ip
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7788));

            //3.接收数据
            new Thread(ReceiveMessage){IsBackground =true}.Start();
            
            //udpServer.Close();
            Console.ReadKey();

        }

        static void ReceiveMessage()
        {
            while (true)
            {
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = new byte[1024];
                int length =
                    udpServer.ReceiveFrom(data, ref remoteEndPoint); //会暂停，直到接收到了才会往下运行 //这个方法会把数据的来源（ip：port）放在第二个参数
                //ref 表示可以修改当前的数据
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("从ip:" + (remoteEndPoint as IPEndPoint).Address.ToString() + ":" +
                                  (remoteEndPoint as IPEndPoint).Port.ToString() + " 收到了数据:" + message);
            }
        }
    }
}
