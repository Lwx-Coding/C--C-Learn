using System;

namespace 力扣测试
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Reverse(123));
            //Console.WriteLine(Reverse(-123));
            //Console.WriteLine(Reverse(120));
            //Console.WriteLine(Reverse(0));
            Console.WriteLine(Reverse(1534236469));
            Console.ReadKey();
        }

        public static int Reverse(int x)
        {
            
            
            bool CompareZero = x >= 0 ? true : false;  //得到正数还是负数

            int biggest = Pow(2, 31) - 1;
            int biggestt = Pow(2, 31) ;
            int minest = -Pow(2, 31) ;

            Console.WriteLine(biggest);
            Console.WriteLine(biggestt);
            int value = Math.Abs(x);
            Console.WriteLine(value);
            string s = (value).ToString();

            if (s.Length > 10) return 0;

            int[] values = new int[s.Length];
            int[] biggests = new int[s.Length];
            int[] minests = new int[s.Length];

            for(int i = 0; i < 10; i++)
            {
                biggests[i]= biggest / Pow(10, s.Length - i - 1);

                biggest %= Pow(10, s.Length - i - 1);

                minests[i] = minest / Pow(10, s.Length - i - 1);

                minest %= Pow(10, s.Length - i - 1);
            }


            for (int i = 0; i < s.Length; i++)
            {
                values[i] = value / Pow(10, s.Length - i - 1);

                value %= Pow(10, s.Length - i - 1);

            }

            int ss = 0;
            if (CompareZero)
            {
                if (s.Length == 10)
                {
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        int pow = Pow(10, i);
                        if (values[i] > biggests[9-i]) return 0;
                        ss += pow * (values[i]);

                    }
                }
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(values[i]);
                    Console.WriteLine(Pow(10, i));
                    ss += Pow(10, i) * (values[i]);
                    Console.WriteLine("ss:"+ss);
                    Console.WriteLine();
                    
                    if (ss > biggest || ss < minest) return 0;
                }
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    ss -= Pow(10, i) * (values[i]);

                    if (ss > biggest || ss < minest) return 0;
                }
            }
            return ss;

            int Pow(int x, int y)
            {
                if (y <= 0) return 1;
                int reValue = x;
                for (int i = 1; i < y; i++)
                {
                    reValue *= x;
                }
                return reValue;
            }
        }
    }
}

