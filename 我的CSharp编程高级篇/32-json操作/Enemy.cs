using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_json操作
{
    class Enemy
    {
        public string Name { get; set; }   //字段或者属性名 要跟json里面的对应
        public int Level { get; set; }
        public int Age { get; set; }
        public List<skill> Skilllist { get; set; }

        public override string ToString()
        {
            return string.Format("Name:{0},Level:{1},Age{2}", Name, Level, Age);
        }
    }
}
