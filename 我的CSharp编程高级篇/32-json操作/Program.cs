using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace _32_json操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用litjson进行解析json文本
            //两种方式引入litjson
            //1.去litjson官网下载litjson.dll然后添加引用 找到dll所在目录
            //2.右击引用 打开管理netget程序包 在联机里面搜索litjson 再搜索结果里面找一个安装

           // List<skill>  skillliList=new List<skill>();

            //1.我们使用jsonMapper去解析json文本
            //jsondata类型代表一个数组或者一个对象
            //这里的jsonData代表数组
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.txt"));

            //foreach (JsonData temp in jsonData)  //这里temp代表一个对象
            //{
            //    skill skill=new skill();
            //    JsonData idValue = temp["id"];//通过字符串索引器可以取得键值对应的值
            //    JsonData nameValue = temp["name"];
            //    JsonData damagevalue = temp["damage"];
            //    int id=Int32.Parse(idValue.ToString());
            //    int damage=Int32.Parse(damagevalue.ToString());
            //    skill.id = id;
            //    skill.damage = damage;
            //    skill.name = nameValue.ToString();
            //    //Console.WriteLine(id+":"+nameValue.ToString()+":"+damage);
            //    skillliList.Add(skill);
            //}
            //foreach (var skill in skillliList)
            //{
            //    Console.WriteLine(skill.ToString());
            //}

            //2.我们使用泛型去解析json   json里面对象的键必须跟类的属性必须名字一致
            //skill[] skillArray = JsonMapper.ToObject<skill[]>(File.ReadAllText("json技能信息.txt"));

            //foreach (var skill in skillArray)
            //{
            //    Console.WriteLine(skill.ToString());
            //}

            //3.数组变集合
            //List<skill> skilllist = JsonMapper.ToObject<List<skill>>(File.ReadAllText("json技能信息.txt"));
            //foreach (var skill in skilllist)
            //{
            //    Console.WriteLine(skill.ToString());
            //}


            //敌人

            //Enemy P = JsonMapper.ToObject<Enemy>(File.ReadAllText("json敌人信息.txt"));
            //Console.WriteLine(P);
            //foreach (var temp in P.Skilllist)
            //{
            //    Console.WriteLine(temp.ToString());
            //}

            //把对象转换成json字符串
            Enemy p=new Enemy();
            p.Name = "花千骨";
            p.Level = 100;
            p.Age = 16;
            string json = JsonMapper.ToJson(p);
            Console.WriteLine(json);
            Console.ReadKey();

        }
    }
}
