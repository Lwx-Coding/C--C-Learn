using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _13_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var masterList=new List<MartialArtsMaster>()
            {
                new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
                new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
                new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
                new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
                new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
                new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
                new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
                new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
                new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
                new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
                new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
            };

            //初始化武学
            var kongfuList = new List<Kongfu>(){
                new Kongfu(){Id=1, Name="打狗棒法", Power=90},
                new Kongfu(){Id=2,  Name="降龙十八掌", Power=95},
                new Kongfu(){Id=3,  Name="葵花宝典", Power=100},
                new Kongfu() { Id=  4,  Name = "独孤九剑", Power = 100 },
                new Kongfu() { Id = 5,  Name = "九阴真经", Power = 100 },
                new Kongfu() { Id = 6,  Name = "弹指神通", Power = 100 }
            };

            //查询所有武学级别大于8的武林高手
            //var res=new List<MartialArtsMaster>();
            //foreach (var temp in masterList)
            //{
            //    if (temp.Level > 8)
            //    {
            //        res.Add(temp);
            //    }
            //}


            //1.使用LINQ做查询（表达式写法）
            //var res = from m in masterList //from后面设临时变量，读取集合里面的值
            //    where m.Level > 8 && m.Menpai == "丐帮" //where后面跟查询的条件 通过&&并列条件 
            //    select m;                              //表示将变量m返回给res

            //2.拓展方法的写法
            //var res = masterList.Where(Test1);
            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");
            
            //3.LINQ联合查询
            //var res = from m in masterList
            //    from k in kongfuList //从两个表里做查询所以创建两个临时变量
            //    where m.Kongfu == k.Name && k.Power > 90
            //    select new {master = m, kongfu = k};             //new 一个临时对象 里面有两个字段
    //重要        //拓展方法的用法
     //       var res = masterList.SelectMany(m => kongfuList, (m, k) => new {master = m, kongfu = k})
    //            .Where(x => x.master.Kongfu == x.kongfu.Name && x.kongfu.Power > 90);
            //这里是做了一个联合查询

            //4.对结果做排序 orderby（descending）
            //var res = from m in masterList
            //    where m.Level > 8 && m.Menpai == "丐帮" //通过&&添加并列条件
            //    orderby m.Level, m.Age                  //先按等级排，要是相同则按第二个，也就是按年龄排
            //    select m;
            //拓展方法
           //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Level).ThenBy(m => m.Age);//先是按Level排，如果level相同则按年龄排
            // res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Level).OrderBy(m => m.Age);//先是按Level排，排完又重新按年龄排。
           
            //5.join on 联合查询
            //var res = from m in masterList
            //    join k in kongfuList on m.Kongfu equals k.Name
            //    where k.Power > 90
            //    select new {master = m, kongfu = k};

            //6.分组查询 into groups
            //var res = from k in kongfuList
            //    join m in masterList on k.Name equals m.Kongfu
            //        into groups
            //    orderby groups.Count()
            //    select new {kongfu = k, count = groups.Count()};

            //7.按照自身字段分组 group
            //var res = from m in masterList
            //    group m by m.Kongfu
            //    into g
            //    select new {count = g.Count(), key = g.Key};
            // //g.key key表示按哪个属性分的组
            
            //8.量词操作符 any all 判断集合中是否满足某个条件
            bool res = masterList.Any(m => m.Menpai == "丐帮");
            Console.WriteLine(res);










            
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}


            Console.ReadKey();
        }

        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8) return true;
            return false;
        }
    }
}
