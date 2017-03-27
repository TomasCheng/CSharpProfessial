using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002events
{
    class Program
    {
        public delegate void MyDelegate();

//        public MyDelegate mydelegate;//
        public event MyDelegate mydelegate;//事件只能在类的成员里面声明

        static void Main(string[] args)
        {
//            Program p =new Program();
//            p.mydelegate = Test1;
//            p.mydelegate();

            Cat cat = new Cat("加菲","黄色");
            Mouse mouse1 = new Mouse("siki","黑色",cat);
            Mouse mouse2 = new Mouse("mike","灰色",cat);

//            //向猫里面的委托注册
//            cat.catCome += mouse1.RunAway;//注册！！！
//            cat.catCome += mouse2.RunAway;

            cat.CatComing();







        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }
    }
}
