using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22_聊天室_socket_tcp服务器端
{
    class Client
    {
        private Socket clientSocket;
        private Thread t;
        private byte[] data=new byte[1024];//是一个数据容器
        public Client(Socket s)
        {
            clientSocket = s;
            //启动一个线程 处理客户端的数据接收
            t=new Thread(ReceiveMessage);
            t.Start();
        }

        private void ReceiveMessage()
        {
            while (true)//一直接收客户端数据
            {
                //在接收数据前 判断一下socket连接是否断开
                if (clientSocket.Poll(10, SelectMode.SelectRead) || clientSocket.Connected == false)  //一个检测，10ms内没有读到数据，那么就是断开了
                { 
                    clientSocket.Close();
                    break; //跳出循环 终止线程的执行
                }


                int length = clientSocket.Receive(data);
                    string message = Encoding.UTF8.GetString(data, 0, length);
                    //TODO:服务器端接收到数据的时候要把这个数据分发到客户端
                    //广播这个消息
                    Program.BroadcastMessage(message);
                    Console.WriteLine("收到了消息:" + message);
                
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
        }

        public bool Connected
        {
            get
            {
                return clientSocket.Connected;
            }
        }
    }
}
