using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_快速排序
{
    class Program
    {   
        //   ///在方法上///代表对方法注释
        /// <summary>
        /// 对数组dataArray中从索引left到right之间的数进行排序
        /// </summary>
        /// <param name="dataArray">要排序的数组</param>
        /// <param name="left">要排序数组的开始索引</param>
        /// <param name="right">要排序数组的结束索引</param>
        static void QuickSort(int[] dataArray, int left,int right)
        {
            if (left < right)
            {
                int x = dataArray[left];//基准数  把比他小的或者等于他的放在他左边 把比他大的放在右边
                int i = left, j = right;//用来作循环的标志位

                while (true&&i<j)//当i==j的时候 我们找到了一个中间位置 这个位置就是基准数所在位置
                {
                    //从后往前做比较(从右往左比较)找一个比x小或者等于的数  放在我们的坑里， 坑在i的位置
                    while (true && i < j)
                    {
                        if (dataArray[j] <= x) //找到了一个比基准数小或者等于的数字 应该把它放在x的左边
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--; //向左移动到下一个数字 然后做比较
                        }
                    }

                    //从前往后做比较（从坐往右）找一个比X大的数组 放在坑里 坑在j的位置
                    while (true && i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }

                }

                //现在i==j   i是中间位置
                dataArray[i] = x;   //left--i--right
                QuickSort(dataArray,left,i-1);
                QuickSort(dataArray,i+1,right);
            }
        }
        static void Main(string[] args)
        {
            int[] data = new int[] { 23, 32, 454, 2, 3, 4, 542, 234, 54 };
            QuickSort(data,0,data.Length-1);
            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
