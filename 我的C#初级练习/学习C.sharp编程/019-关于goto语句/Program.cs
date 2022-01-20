using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_关于goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            goto mylabel;
            x++;
        mylabel:
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
