using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取每一行，组成一个字符串数组
//            string[] strArray = File.ReadAllLines("TextFile1.txt");
//
//            foreach (var s in strArray)
//            {
//                Console.WriteLine(s);
//            }

//            string s= File.ReadAllText("TextFile1.txt");
//            Console.WriteLine(s);


//            byte[] dataBytes = File.ReadAllBytes("3.LINQ.png");
//
//            foreach (var dataByte in dataBytes)
//            {
//                Console.Write(dataByte+" ");
//            }

//            File.WriteAllText("a.txt","你好呀！");

            byte x = Convert.ToByte(255);
            byte[] dataBytes = File.ReadAllBytes("3.LINQ.png");
//            for (int i = 10240; i < dataBytes.Length - 1024; i++)
//            {
//                dataBytes[i] =x  - dataBytes[i];
//
//            }
            Console.WriteLine("字节数："+dataBytes.Length);

            File.WriteAllBytes("b.png",dataBytes);

//            File.WriteAllLines("c.txt",new string[] {"231","32131"});

            Console.WriteLine("结束");

            Console.ReadKey();
        }
    }
}
