using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的定义和声明
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 v3 = new Vector3(1, 1, 1);

            v3.MyintProperty = 600;
            int temp = v3.MyintProperty;
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
