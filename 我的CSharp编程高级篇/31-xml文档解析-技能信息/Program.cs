using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _31_xml文档解析_技能信息
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill>  skilllList=new List<Skill>();
            XmlDocument xmlDoc=new XmlDocument();
           // xmlDoc.Load("xml技能信息.txt");
            xmlDoc.LoadXml(File.ReadAllText("xml技能信息.txt"));//传递一个字符串 xml各式的字符串
            XmlNode skillinfoNode = xmlDoc.FirstChild;
            XmlNode skilllist = skillinfoNode.FirstChild;

            XmlNodeList skillNodeList = skilllist.ChildNodes;
            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill=new Skill();
                XmlElement ele = skillNode["Name"];
                skill.Name = ele.InnerText;   //有点小bug 转成？？？了

                XmlAttributeCollection col = skillNode.Attributes;//获得该结点属性的集合
                skill.Id=Int32.Parse(col["SkillID"].Value);     //通过字符串索引器 获得一个属性对象
                skill.EngName = col["SkillEngName"].Value;
                skill.TriggerType = Int32.Parse( col["TriggerType"].Value);
                skill.ImageFile = col["ImageFile"].Value;
                skill.AvailableRace=Int32.Parse(col["AvailableRace"].Value);
                skilllList.Add(skill);
            }

            foreach (var skill in skilllList)
            {
                Console.WriteLine(skill.ToString());
            }

            Console.ReadKey();
        }
    }
}
