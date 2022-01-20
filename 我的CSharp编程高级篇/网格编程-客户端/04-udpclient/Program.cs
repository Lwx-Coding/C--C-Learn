using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _04_udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient对象
            UdpClient client=new UdpClient();
            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);

                client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("10.161.145.140"), 7788));
            }


            client.Close();
            Console.ReadKey();
        }
    }
}
