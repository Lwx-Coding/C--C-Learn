using System;

namespace 力扣测试
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Merge(new int[] { 1,2,3,0,0,0},6,new int[] { 2, 5, 6 },3));
            Console.WriteLine(Merge(new int[] { 0},0,new int[] { 1 },1));
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int num1Cur_Length = m ;
            int lastInsert = 0;
            if (m == 0)
            {
                nums1 = nums2;
            }
            else
            for (int i = 0; i < n; i++)
            {
                //将2全部放入1
                for (int j = lastInsert; j < num1Cur_Length; j++)
                {
                    if (nums1[j] > nums2[i])
                    {
                        nums1 = InsertInto(nums1, j, nums2[i]);
                        lastInsert = j;
                        num1Cur_Length++;
                        break;
                    }
                    else if (j == num1Cur_Length - 1)
                    {
                        nums1[num1Cur_Length++] = nums2[i];
                        break;
                    }
                }
            }
            return nums1;

            int[] InsertInto(int[] num, int index, int value)
            {
                for (int i = num.Length - 1; i > index; i--)
                {
                    num[i] = num[i - 1];
                }
                num[index] = value;

                return num;
            }
        }
    }
}
