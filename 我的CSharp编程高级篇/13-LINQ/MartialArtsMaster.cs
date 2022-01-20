using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_LINQ
{
    class MartialArtsMaster
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Menpai { get; set; }

        public string Kongfu { get; set; }

        public int Level { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0},Name:{1},Age:{2},Menpai:{3},Kongfu:{4},Level:{5}", Id, Name, Age, Menpai,
                Kongfu, Level);
        }
    }
}
