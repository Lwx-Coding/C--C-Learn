using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_数组的排序
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] res = str.Split(' ');
            int[] number = new int[res.Length];
            for(int i=0;i<res.Length;i++){
                int temp = Convert.ToInt32(res[i]);
                number[i] = temp;
            }
            //Array.Sort(number);   //从小到大自动排序
            //for(int i = 0; i < number.Length; i++)
            //{
            //    Console.Write(number[i]+" ");
            //}
            for(int i = 0; i < number.Length; i++)
            {
                for(int j = i; j < number.Length; j++)
                {
                    if (number[j] < number[i])
                    {
                        int temp = number[j];
                        number[j] = number[i];
                        number[i] = temp;
                    }
                }
            }
            for(int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]+" ");
            }
        }
    }
}
