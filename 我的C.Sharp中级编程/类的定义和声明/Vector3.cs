using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的定义和声明
{
    public class Vector3
    {
        public Vector3()
        {
            Console.WriteLine("Vector3的构造函数被调用了");

        }

        public Vector3(float x,float y,float z)
        {
            this.x= x;
            this.y = y;
            this.z = z;
            length = Length();

        }

        private float x, y, z, length;
        private int age;

        public string Name { get; set; }

        public int Age
        {
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public void SetX(float x)
        {
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }

        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public int MyintProperty
        {
            set
            {
                Console.WriteLine("set： " + value);
            }
            get
            {
                return 100;
            }
        }
    }
}
