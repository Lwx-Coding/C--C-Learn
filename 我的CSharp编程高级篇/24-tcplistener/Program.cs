using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _24_tcplistener
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tcplistener对socket进行了一层封装，这个类里面再加回去创建Socket对象
            TcpListener listener=new TcpListener(IPAddress.Parse("10.161.145.140"),7788 );
            //开始监听
            listener.Start();
            //等待客户端连接
            TcpClient client= listener.AcceptTcpClient();//接收一个客户端连接

            //获得客户端发来的数据
            NetworkStream stream = client.GetStream();//得到了一个网络流，从这个网络流就可以取得客户端发送过来的数据

            byte[] data=new byte[1024];//创建一个数据的容器，用来承接数据
            while (true)
            {
                //0 表示从数组的哪个索引开始存放数据
                //1024 表示最大读取的字节数
                int length = stream.Read(data, 0, 1024);
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("收到了消息:" + message);
            }
           

            stream.Close();
            client.Close();
            listener.Stop();
            Console.ReadKey();
        }
    }
}
