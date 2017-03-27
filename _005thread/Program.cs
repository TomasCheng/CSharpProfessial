using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005thread
{
    class Program
    {
        public static int Test(int i)
        {
            Console.WriteLine("test,i:"+i);
            Thread.Sleep(2000);
            Console.WriteLine("test,i:" + i);
            return i + 1;
        }

        public static void DownLoadFile(object fileName)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("开始下载");
            Console.WriteLine(fileName as string);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("<");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("下载结束");
        }

        static void Main(string[] args)
        {
//            Func<int, int> func = Test;
//            IAsyncResult result = func.BeginInvoke(2, ar =>
//            {
//                int m = func.EndInvoke(ar);
//                Console.WriteLine(m);
//
//                Console.WriteLine("子线程结束");
//            }, null);
//            while (result.IsCompleted == false)
//            {
//                Thread.Sleep(100);
//                Console.Write(">");
//            }

//            bool isEnd =  result.AsyncWaitHandle.WaitOne(3000);//暂停当前线程
//            int m=0;
//            if (isEnd)
//            {
//                m = func.EndInvoke(result);
//            }
            

//            Console.WriteLine("main"+m);

//            Console.ReadKey();

//            Thread t = new Thread(DownLoadFile);
//
//            string fileName = "xxx";
//            Thread t =new Thread(() =>
//            {
//                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//                Console.WriteLine(fileName);
//                Console.WriteLine("开始下载");
//                for (int i = 0; i < 10; i++)
//                {
//                    Console.Write("<");
//                    Thread.Sleep(100);
//                }
//                Console.WriteLine();
//                Console.WriteLine("下载结束");
//            });

//            t.Start(fileName);

            MyThread my = new MyThread("xxx.bt","http://www.xxx.org");
            Thread t = new Thread(my.DownLoadFile);
            t.Start();
            Console.WriteLine("main");




        }
    }

    
}
