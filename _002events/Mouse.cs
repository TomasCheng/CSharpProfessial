using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002events
{
    /// <summary>
    /// 观察者
    /// </summary>
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome += RunAway;//订阅消息
        }

        public void RunAway()
        {
            Console.WriteLine(color+"的老鼠"+name+"说：老鼠来啦！我跑掉啦！");
        }
    }
}
