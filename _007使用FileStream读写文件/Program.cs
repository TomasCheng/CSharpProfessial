using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
//            //创建文件流对象
//            FileStream fileStream = new FileStream("a.txt",FileMode.Open);
//
//            //通过流操作文件
//            byte[] data = new byte[1024];
//            StringBuilder sb = new StringBuilder();
//            int sumLen = 0;
//
//            //超出容器时，用循环来操作
//            while (true)
//            {
//                int len = fileStream.Read(data, 0, 1024);
//                if (len == 0)
//                {
//                    Console.WriteLine("读取结束");
//                    break;
//                }
//                for (int i = 0; i < len; i++)
//                {
//                    Console.Write(data[i] + " ");
//                }
//                sumLen += len;
//                string message = Encoding.UTF8.GetString(data, 0, len);
//                sb.Append(message);
//
//            }
//
//            
//            Console.WriteLine();
//
//
//
//
//
//            Console.WriteLine(sb.ToString());
//
//            Console.WriteLine("字节数："+sumLen);


            //使用filestream完成文件的复制

            //读取流
            FileStream readstream = new FileStream("3.png",FileMode.Open);
            //写入流
            FileStream writeStream = new FileStream("new3.png",FileMode.Create);

            //容器
            byte[] data = new byte[1024];

            //循环读取
            while (true)
            {
                int len = readstream.Read(data, 0, data.Length);
                if (len == 0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }

                writeStream.Write(data,0,len);
            }

            writeStream.Close();
            readstream.Close();


            Console.ReadKey();

        }
    }
}
