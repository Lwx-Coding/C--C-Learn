using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_特性
{
    //特性类的后缀以Attribute结尾
    //需要继承自System.Attribute
    //一般情况下声明为 sealed
    //一般情况下 特性类用来表示目标结构的一些状态（定义一些字段或者属性，一般不定义方法）
    class MyTestAttribute:System.Attribute
    {
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public int ID { get; set; }

        public MyTestAttribute(string des)
        {
            this.Description = des;
        }
    }
}
