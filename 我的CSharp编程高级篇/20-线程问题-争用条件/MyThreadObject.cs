using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_线程问题_争用条件
{
    class MyThreadObject
    {
        private  int state = 5;

        public  void ChangeState()
        {
            state++;
            Console.WriteLine(state);
            if (state == 5)
            {
                Console.WriteLine("state=5");
            }

            state = 5;
        }
    }
}
