using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _007_冒泡排序之面向对象;

namespace _07_冒泡排序之面向对象
{
    class Program
    {
        static void Sort(int[] sortArray)  
        {//改进的冒泡排序算法，如果没有发生交换，就代表全部排好序了
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void CommonSort<T>(T[] sortArray, Func<T, T, bool> compareMethod)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
        static void Main(string[] args)
        {
            int[] sortArray=new int[]{123,34,532,26,45,245,24,2,4};
            Sort(sortArray);
            foreach (var temp in sortArray)
            {
              Console.Write(temp+" ");   
            }
            Console.WriteLine();
            Employee[] employee = new Employee[]
            {
                new Employee("dwa", 123),
                new Employee("weer", 2313),
                new Employee("3e3r2r", 314134),
                new Employee("f3ff2", 13135)
            };
            CommonSort<Employee>(employee,Employee.Compare);
            foreach (var e in employee)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
