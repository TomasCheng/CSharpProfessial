using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005ThreadPool
{
    class Program
    {
        static void ThreadMethod()
        {
            Console.WriteLine("线程"+Thread.CurrentThread.ManagedThreadId + "开始下载");
//            Console.WriteLine(path + "//" + name);
//            for (int i = 0; i < 10; i++)
//            {
//                Console.Write("<");
//                Thread.Sleep(100);
//            }
//            Console.WriteLine();

            Thread.Sleep(2000);
            Console.WriteLine("线程" + Thread.CurrentThread.ManagedThreadId + "下载结束");
        }
        static void Main(string[] args)
        {
//            ThreadPool.QueueUserWorkItem(ThreadMethod);
//            ThreadPool.QueueUserWorkItem(ThreadMethod);
//            ThreadPool.QueueUserWorkItem(ThreadMethod);
//            ThreadPool.QueueUserWorkItem(ThreadMethod);
//            Console.ReadKey();


//            Task t= new Task(ThreadMethod);//创建任务，相当于对线程进行了封装
//            t.Start();

//            TaskFactory tf = new TaskFactory();
//            Task t = tf.StartNew(ThreadMethod);

            //线程问题，争用条件


            
            

            Console.WriteLine("main");
            Console.ReadKey();

        }
    }
}
