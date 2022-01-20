using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _21_socket编程_TCP协议_服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.绑定ip跟端口号 10.161.145.140 10.161.156.235
            IPAddress ipAddress = new IPAddress(new byte[] {127, 0, 0, 1});  
            EndPoint point = new IPEndPoint(ipAddress, 7788); //ipendpoint是对ip+端口做了封装的类
            tcpServer.Bind(point); //向操作系统申请一个可以用的ip跟端口号  用来做通信

            //3.开始监听 等待客户端连接
            tcpServer.Listen(100); //参数是最大连接数
            Console.WriteLine("开始监听");

            Socket clientSocket = tcpServer.Accept(); //暂停当前线程，直到有一个客户端连接过来，之后进行下面的代码
            //使用返回的socket跟客户端做通信
            Console.WriteLine("一个客户端连接过来了");
            string message = "hello 欢迎您";
            byte[] data = Encoding.UTF8.GetBytes(message); //对字符串做编码，得到一个字符串的字节数组
            clientSocket.Send(data);
            Console.WriteLine("向客户端发送了一条数据");

            byte[] data2=new byte[1024];  //创建了一个字节数组用来做容器，去承接从客户端发来的消息
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);
            Console.WriteLine("从客户端接收到了一条消息："+message2);


            Console.ReadKey();
        }
    }
}
