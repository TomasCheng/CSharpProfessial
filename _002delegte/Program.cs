using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002delegte
{
    class Program
    {
        private delegate string GetAString();
        static void Main(string[] args)
        {

//            GetAString firstStringMethod = Method1;
//
//            Console.WriteLine(firstStringMethod());
//           
//            firstStringMethod = Method2;
//            Console.WriteLine(firstStringMethod());

//            Action<int> a;

//            Man[] men =
//            {
//                new Man("A", 17),
//                new Man("B", 12),
//                new Man("C", 14),
//                new Man("D", 15),
//                new Man("E", 2),
//                new Man("F", 4),
//            };
//            
//
//            Sort<Man>(men,Man.CompareAge);
//            foreach (var man in men)
//            {
//                Console.WriteLine(man);
//            }

//            Func<string> a = Method1;
//            a += Method2;
//            Delegate[] delegates = a.GetInvocationList();
//            foreach (Delegate d in delegates)
//            {
//                Console.WriteLine(d.DynamicInvoke());
//            }

//            Func<int,int,int> plus = delegate(int a, int b) { return a + b; };

            int m = 10;
            Func<int, int, int> plus = (arg1, arg2) => { return m + arg1 + arg2; };//lambda表达式可以访问外部变量
            Console.WriteLine(plus(1,2));

//            Console.ReadKey();

        }

        private static string Method1()
        {
            return "method1";
        }
        private static string Method2()
        {
            return "method2";
        }
        /// <summary>
        /// 通用的冒泡排序方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sList"></param>
        /// <param name="compFunc"></param>
        public static void Sort<T>(T[] sList,Func<T,T,bool> compFunc )
        {
            bool swapped = true;
            T temp;
            int count = 0;
            do
            {
                swapped = false;
                for (int i = 0; i < sList.Length-1; i++)
                {
                    if (compFunc(sList[i], sList[i+1]))
                    {
                        temp = sList[i + 1];
                        sList[i + 1] = sList[i];
                        sList[i] = temp;
                        swapped = true;
                        count++;
                    }
                }

            } while (swapped);
            Console.WriteLine("排序循环次数："+count+"次");
        }
    }



    class Man
    {
        private string name;
        private int age;

        public Man(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static bool CompareAge(Man m1,Man m2)
        {
            return m1.age > m2.age;
        }




        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return "name:" + name + ",age:" + age;
        }
    }
}
