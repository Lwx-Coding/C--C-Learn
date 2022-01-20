using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_通过Thread发起线程
{
    class MyThred
    {
        private string filename;
        private string filepath;

        public MyThred(string filename, string filepath)
        {
            this.filepath = filepath;
            this.filename = filename;
        }

        public void DownLoad()
        {
            Console.WriteLine("开始下载"+filepath+filename);
            Thread.Sleep(5000);
            Console.WriteLine("下载完成" + filepath + filename);
        }
    }
}
