#define test
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _004attribute
{
    class Program
    {
        [Obsolete("该方法已经弃用，请使用newMethod替换")]
        public static void test01()
        {
            Console.WriteLine("test01");
        }

        [Conditional("TRACE")]
        public static void newMethod() => Console.WriteLine("new method");

        static void Main(string[] args)
        {
//            MyClass m =new MyClass();
//            Type type = m.GetType();
//            Console.WriteLine(type.Name);
//            Console.WriteLine(type.Namespace);
//            Console.WriteLine(type.Assembly);
//            FieldInfo[] d=type.GetFields();
//
//            foreach (var fieldInfo in d)
//            {
//                Console.WriteLine(fieldInfo.Name);
//            }
//
//            MethodInfo[] methodsInfos = type.GetMethods();
//            foreach (var methodsInfo in methodsInfos)
//            {
//                Console.WriteLine(methodsInfo.Name);
//            }

            test01();
            newMethod();
            
        }
    }
}
