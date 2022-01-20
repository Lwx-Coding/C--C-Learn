using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_json操作
{
    class skill
    {
        public int id { get; set; } 
        public int damage { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("id:{0},damage{1},name{2}", id, damage, name);
        }
    }
}
