using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _03_tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //2.发送建立连接的请求 10.161.156.235
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");//可以把一个字符串的ip地址转化成一个ipaddress的对象

            EndPoint point = new IPEndPoint(ipAddress, 7788);
            tcpClient.Connect(point);  //通过端口号和ip 定位一个要连接到的服务器端   自身会被系统随机建立一个ip和端口号

            byte[] data = new byte[1024];//创建一个数据的容器，用来承接数

            while (true)//利用一个死循环进行重复操作
            {
                //read用来读取数据 write用来写入数据其实就是发送数据
                string message1 = Console.ReadLine();
                byte[] data1 = Encoding.UTF8.GetBytes(message1);
                tcpClient.Send(Encoding.UTF8.GetBytes(message1));//把字符串转化成字节数组，然后发送给服务器端
                //0 表示从数组的哪个索引开始存放数据
                //1024 表示最大读取的字节数
                int length = tcpClient.Receive(data);  //这里传递一个byte数组，实际上这data数组用来接收数据
                                                       //length返回值代表接收了多少字节的数据
                string message = Encoding.UTF8.GetString(data, 0, length);  //只把接收到的数据做一个转化
                Console.WriteLine(message);
                
            }


        }

    }

}
