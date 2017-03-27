using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002events
{
    /// <summary>
    /// 被观察者
    /// </summary>
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void CatComing()
        {
            Console.WriteLine(color+"的猫"+name+"过来啦！");
            if (catCome != null)
            {
                catCome();
            }
            
        }

        public event Action catCome;//发布一个消息
    }
}
