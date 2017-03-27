using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005thread
{
    class MyThread
    {
        private string name;
        private string path;

        public MyThread(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public void DownLoadFile(object man)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.Write(man as string+ "开始下载");
            Console.WriteLine(path +"//"+ name);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("<");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("下载结束");
        }
    }
}
