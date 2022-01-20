using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构函数的调用
{
    struct CustomerName
    {
        public string firstName;
        public string lastName;
        public string GetName()
        {
            return firstName + " " + lastName;
        }

    }
    struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerName myname;
            myname.firstName = "wenxin";
            myname.lastName = "liu";
            Console.WriteLine("My name is" + myname.GetName());
            Vector3 vector1;
            vector1.x = 3;
            vector1.y = 3;
            vector1.z = 3;
            Console.WriteLine("长度是:{0}",vector1.Distance()); 
            Console.ReadKey();
        }
    }
}
