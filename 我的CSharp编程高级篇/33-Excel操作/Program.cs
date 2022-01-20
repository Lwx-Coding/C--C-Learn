using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "装备信息.xls";
            string connectionString =
                "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filename + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";


            OleDbConnection connection =new OleDbConnection(connectionString);

            //打开连接
            connection.Open();

            string sql = "select * from [Sheet1$]";   //这是一个查询命令

            OleDbDataAdapter adapter=new OleDbDataAdapter(sql,connection);

            DataSet dataSet=new DataSet();  //用来存放数据 用来存放DataTabel

            adapter.Fill(dataSet);  //表示把查询的结果（datatable）放到（填充）dataset里面

            connection.Close();  //释放连接资源

            //取得数据
            DataTableCollection tableCollection = dataSet.Tables;  //获得当前集合中全部表格
            DataTable table = tableCollection[0];//因为我们只往dataset里面放置了一张表格，所以这里取得索引为0的表格就是我们刚刚查询到的表格

            //取得表格中的数据
            //取得table中的所有行
            DataRowCollection rowCollection = table.Rows;//返回了一个行的集合

            //遍历行的集合 取得每一个行的datarow对象
            foreach (DataRow row in rowCollection)
            {
                //取得row中前八列的数据 索引0-7
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
