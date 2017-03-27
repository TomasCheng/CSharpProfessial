using System;
using System.Collections.Generic;
using System.Linq;

namespace _003LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //初始化武林高手
            var master = new List<MartialArtsMaster>
            {
                new MartialArtsMaster {Id = 1, Name = "黄蓉", Age = 18, Menpai = "丐帮", Kungfu = "打狗棒法", Level = 9},
                new MartialArtsMaster {Id = 2, Name = "洪七公", Age = 70, Menpai = "丐帮", Kungfu = "打狗棒法", Level = 10},
                new MartialArtsMaster {Id = 3, Name = "郭靖", Age = 22, Menpai = "丐帮", Kungfu = "降龙十八掌", Level = 10},
                new MartialArtsMaster {Id = 4, Name = "任我行", Age = 50, Menpai = "明教", Kungfu = "葵花宝典", Level = 1},
                new MartialArtsMaster {Id = 5, Name = "东方不败", Age = 35, Menpai = "明教", Kungfu = "葵花宝典", Level = 10},
                new MartialArtsMaster {Id = 6, Name = "林平之", Age = 23, Menpai = "华山", Kungfu = "葵花宝典", Level = 7},
                new MartialArtsMaster {Id = 7, Name = "岳不群", Age = 50, Menpai = "华山", Kungfu = "葵花宝典", Level = 8},
                new MartialArtsMaster {Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kungfu = "独孤九剑", Level = 10},
                new MartialArtsMaster {Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kungfu = "九阴真经", Level = 8},
                new MartialArtsMaster {Id = 10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kungfu = "弹指神通", Level = 10},
                new MartialArtsMaster {Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kungfu = "独孤九剑", Level = 10}
            };
            //初始化武学
            var kongfu = new List<Kongfu>
            {
                new Kongfu {KongfuId = 1, KongfuName = "打狗棒法", Lethality = 90},
                new Kongfu {KongfuId = 2, KongfuName = "降龙十八掌", Lethality = 95},
                new Kongfu {KongfuId = 3, KongfuName = "葵花宝典", Lethality = 100},
                new Kongfu {KongfuId = 4, KongfuName = "独孤九剑", Lethality = 100},
                new Kongfu {KongfuId = 5, KongfuName = "九阴真经", Lethality = 100},
                new Kongfu {KongfuId = 6, KongfuName = "弹指神通", Lethality = 100}
            };

            //查询所有武学级别大于8的武林高手
            //            var res = new List<MartialArtsMaster>();

            //foreach方法            
            //            foreach (var martialArtsMaster in master)
            //            {
            //                if (martialArtsMaster.Level > 8)
            //                {
            //                    res.Add(martialArtsMaster);
            //                }
            //            }

            //使用LINQ来查询,表达式写法
            //            var res = from m in master
            //                where m.Level > 8 
            //                select m.Kungfu;

            //扩展方法的写法
            //            var res = master.Where(Test1);

            //使用Lambda表达式
            //            var res = master.Where(m => m.Level > 8 && m.Menpai.Equals("丐帮"));

            //联合查询
            //            var res = from m in master
            //                from k in kongfu
            ////                where m.Kungfu == k.KongfuName && k.Lethality > 99
            ////                select new {mm = m, kk = k};//new了一个临时对象
            //                select k;

            //联合查询拓展方法
            //        原来的集合.selectMany(联合查询的集合，传回来的结果).where(过滤条件)
            //            var res = master.SelectMany(m=>kongfu, (m, k) => new {mm = m, kk = k}).Where(x=> x.mm.Kungfu == x.kk.KongfuName );
            //对结果进行排序orderby  thenby
            //            var res = from m in master
            //                where m.Level > 8
            //                orderby m.Age,m.Id
            //                select m;

            //            var res = master.Where(m => m.Level > 8).OrderBy(m => m.Age).ThenBy(m=>m.Id);


            //join on 关键字联合查询
            //            var res = from m in master
            //                join k in kongfu on m.Kungfu equals k.KongfuName
            //                where k.Lethality >= 90 && m.Menpai == "丐帮"
            //                orderby m.Level, k.Lethality
            //                select new {mm = m, kk = k};



            //into 关键字进行分组
            var res = from m in master
                          //                where m.Level > 9
                      group m by m.Menpai
                into g
                      select new { menpai = g.Key, count = g.Count() };



            //group  by into按照自身字段分组

            //量词操作符all any

            Console.WriteLine(master.All(m => m.Level > 9));

            Console.WriteLine(master.Any(m => m.Id == 3));


            int count = 0;
            foreach (var temp in res)
            {
                count++;
                Console.WriteLine(temp);
            }
            Console.WriteLine("集合元素个数：" + count);
            Console.WriteLine();

        }

        private static bool Test1(MartialArtsMaster m)
        {
            if (m.Level > 8)
            {
                return true;
            }
            return false;
        }
    }
}