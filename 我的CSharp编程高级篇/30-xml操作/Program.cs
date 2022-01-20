using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _30_xml操作
{
    class Program
    {
        static void Main(string[] args)
        { 
            //创建技能信息集合 用来存储所有的技能信息
            List<skill> skillList=new List<skill>();

            //XmlDocument是专门用来解析xml文档的
            XmlDocument xmlDoc=new XmlDocument();
            //选择要加载解析的xml文档的名字
            //xmlDoc.Load("sikll.txt");
            xmlDoc.LoadXml(File.ReadAllText("sikll.txt"));//传递一个字符串 xml各式的字符串

            //得到根节点
            XmlNode rootNode = xmlDoc.FirstChild; //获取第一个结点

            //获得根节点下面的子节点
            XmlNodeList skillNodeList = rootNode.ChildNodes;//获得当前结点下面的所有子节点

            foreach (XmlNode skillNode in skillNodeList)
            {
                skill skill=new skill();
                XmlNodeList fieleNodeList = skillNode.ChildNodes;   //获取skill结点下的所有结点
                foreach (XmlNode fieldNode in fieleNodeList)
                {
                    if (fieldNode.Name == "id") //通过Name属性 可以获取一个结点的名字
                    {
                        int id=Int32.Parse(fieldNode.InnerText);   //获取结点内部的文本
                        skill.Id = id;
                    }else if (fieldNode.Name == "name")
                    {
                        string name = fieldNode.InnerText;
                        skill.Name = name;
                        skill.Lang = fieldNode.Attributes[0].Value;//获取第一个属性
                    }else if (fieldNode.Name == "damage")
                    {
                        skill.Damage=Int32.Parse(fieldNode.InnerText);
                    }
                }
                skillList.Add(skill);
            }

            foreach (var skill in skillList)
            {
                Console.WriteLine(skill.ToString());
            }

            Console.ReadKey();
        }
    }
}
