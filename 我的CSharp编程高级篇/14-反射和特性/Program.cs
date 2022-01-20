using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _14_反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一类对应一个type对象，这个type对象存储了这个类 有哪些方法跟 哪些数据 哪些成员
            Myclass my=new Myclass();  //一个类中的数据 是存储在对象中的 但是type对象只存储类的成员，不存值
            Type type = my.GetType();      //通过对象获取这个对象所属类的Type对象
            Console.WriteLine(type.Name);      //获取类的名字
            Console.WriteLine(type.Namespace);   //获取所在的命名空间
            Console.WriteLine(type.Assembly);

            FieldInfo[] array = type.GetFields();   //只能获取public字段
            foreach (var info in array)
            {
                Console.WriteLine(info.Name+" ");
            }
            Console.WriteLine();

            PropertyInfo[] array2 = type.GetProperties();
            foreach (var info in array2)
            {
                Console.WriteLine(info.Name + " ");
            }
            Console.WriteLine();

            MethodInfo[] array3 = type.GetMethods();
            foreach (MethodInfo info in array3)
            {
                Console.WriteLine(info.Name + " ");
            }
            //通过Type对象可以获取它对应的类的所有成员 public
            Console.WriteLine();


            Myclass my1=new Myclass();
            Assembly assem = my.GetType().Assembly;   //通过类的Type对象获取它所在的程序集 Assembly
            Console.WriteLine(assem.FullName);
            Console.WriteLine();
            Type[] types = assem.GetTypes();
            foreach (var typee in  types)
            {
             Console.WriteLine(typee);   
            }
            Console.ReadKey();
            
            

        }
    }

}
    

