using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _22_聊天室_socket_tcp服务器端
{
    class Program
    {
        private static List<Client> clientList = new List<Client>();

        public static void BroadcastMessage(string message)
        {
            var notconnectedList=new List<Client>();
            foreach (var client in clientList)
            {
                if(client.Connected)
                client.SendMessage(message);
                else
                {
                    notconnectedList.Add(client);
                }
            }

            foreach (var tempClient in notconnectedList)
            {
                clientList.Remove(tempClient);
            }
        }
        static void Main(string[] args)
        {
            //1.创建socket
            Socket tcpServer=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            //2.绑定端口号和ip等待连接 10.161.156.235
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"),7788));
            tcpServer.Listen(100);//最多支持一百个客户端
            Console.WriteLine("Server running....");

            while (true)
            {
                Socket clintSocket = tcpServer.Accept();    //连接到了一个客户端
                Console.WriteLine("a client is connected!");
                Client client=new Client(clintSocket);      //把与每个客户端通信的逻辑（收发消息）放到client类里面进行处理
                clientList.Add(client);                     
            }

        }
    }
}
