using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007使用StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文本文件读取流
//            StreamReader streamReader = new StreamReader("a.txt");

//            while (true)
//            {
//                string str = streamReader.ReadLine();
//                if (str == null)
//                {
//                    break;
//                }
//                Console.WriteLine(str);
//            }
            
            //读取到文件尾
//            Console.WriteLine(streamReader.ReadToEnd());

            //按字符读取
//            while (true)
//            {
//                int res = streamReader.Read();
//                if (res == -1)
//                {
//                    break;;
//                }
//
//                Console.Write((char)res);
//            }
            
            StreamWriter streamWriter = new StreamWriter("a.txt");
            while (true)
            {
                string s = Console.ReadLine();
                if(s == "q")
                    break;
//                streamWriter.Write(s);
                streamWriter.WriteLine(s);
            }
            Console.WriteLine("退出");


//            streamReader.Close();

            
            streamWriter.Close();//写入流不关闭，写入的内容最后就没有写进去！！

            Console.ReadKey();
        }
    }
}
