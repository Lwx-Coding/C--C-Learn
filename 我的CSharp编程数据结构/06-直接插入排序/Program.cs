using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_直接插入排序
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int Ivalue = dataArray[i];
                bool isInsert = false;
                //拿到i位置的元素 跟前面所有元素作比较
                //如果发现比i大的 就让它向后移动
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dataArray[j] > Ivalue)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        //发现一个比i小的值 就不移动了
                        dataArray[j+1] = Ivalue;
                        isInsert = true;
                        break;
                    }

                }
                if (isInsert == false)
                {
                    dataArray[0] = Ivalue;
                }


            }
        }
        static void Main(string[] args)
        {
            int[] data=new int[]{23,32,454,2,3,4,542,234,54};
            InsertSort(data);
            foreach (var temp in data)
            {
                Console.Write(temp+" ");
            }

            Console.ReadKey();
        }
    }
}
