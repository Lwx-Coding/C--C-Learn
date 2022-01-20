using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_变量的类型
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mybyte = 129;         //0-255
            int score = 999;
            long count = 1000000000003;
            Console.WriteLine("byte:{0}int{1}long:{2}",mybyte,score,count);


            float myfloat = 12.5f;     //float后面加f，因为12.5默认为double
            double mydouble = 2332.434;
            Console.WriteLine("float:{0}double:{1}", myfloat, mydouble);

            char mychar = '1';
            string mystring = "";
            string mystring2 = "123";
            bool boolean = false;
            Console.WriteLine("char:{0} string1:{1} string2:{2} boolean:{3}", mychar, mystring, mystring2, boolean);
                }
    }
}
