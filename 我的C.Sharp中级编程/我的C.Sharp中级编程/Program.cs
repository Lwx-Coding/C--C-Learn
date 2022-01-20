using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 我的C.Sharp中级编程
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1;
            customer1 = new Customer();
            customer1.name = "siki";
            customer1.show();
            Console.ReadKey();
        }
    }
}
