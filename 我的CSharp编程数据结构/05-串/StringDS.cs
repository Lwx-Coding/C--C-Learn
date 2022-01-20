using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_串
{
    class StringDS
    {
        private char[] data;//用来存放字符串中的字符

        public StringDS(char[] array)
        {
            data=new char[array.Length];
            for(int i=0;i<array.Length;i++)
            {
                data[i] = array[i];
            }
        }

        public StringDS(string array)
        {
            data=new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                data[i] = array[i];
            }
        }

        //根据索引访问字符的索引器
        public char this[int index]
        {
            get { return data[index]; }
        }

        public int GetLength()
        {
            return data.Length;
        }

        //串比较
        //如果两个完全一样 返回0
        //如果当前字符串小于s 返回-1
        //如果当前字符串大于s 返回1
        public int Compare(StringDS s)
        {
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();//取得两个字符串更小的那个长度
            int index = -1;
            for (int i = 0; i < len; i++)
            {
                if(this[i]!=s[i]){ index = i;break;
                }
            }

            if (index != -1)
            {
                if (this[index] > s[index]) return 1;
                else return -1;
            }
            else
            {
                if (this.GetLength() == s.GetLength()) return 0;
                else if (this.GetLength() > s.GetLength()) return 1;
                else return -1;
            }
        }

        //求子串
        public StringDS SubString(int index, int length)
        {
            char[] newdata = new char[length];
            for(int i=index;i<index+length;i++)
            {
                newdata[i-index] = data[i];
            }
            StringDS newStringDs=new StringDS(newdata);
            return newStringDs;
        }

        //连接串
        public static StringDS Contact(StringDS s1, StringDS s2)
        {
            char[] newData=new char[s1.GetLength()+s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for(int i=0;i<s2.GetLength();i++)
            {
                newData[s1.GetLength() + i] = s2[i];
            }
            return new StringDS(newData);
        }

        //求子串位置
        public int IndexOf(StringDS s)
        {
            for(int i=0;i<=this.GetLength()-s.GetLength();i++)
            {
                bool isEqual = true;
                for(int j=0;j<s.GetLength();j++ ){
                    if (s[j] != this[j+i]) isEqual = false;
                }

                if (isEqual == true) return i;
            }

            return -1;
        }

        public string Tostring()
        {
            return new string(data);
        }
    }
}
