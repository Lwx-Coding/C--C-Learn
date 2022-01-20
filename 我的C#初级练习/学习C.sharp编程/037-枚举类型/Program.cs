using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_枚举类型
{
    enum GameState:byte   //修改该枚举类型的存储类型，默认为int
    {
        Pause,  //默认0
        Failed,  //默认1
        Success,
        Start
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameState state = GameState.Start;
            if (state == GameState.Start)
            {
                Console.WriteLine("当前处于游戏开始状态");
            }
            int num = (int)state;
            Console.WriteLine(num);
            Console.WriteLine(state);
            Console.ReadKey();
        }
    }
}
