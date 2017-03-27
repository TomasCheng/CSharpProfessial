using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _Wolf
{
    class Program
    {
        static void Main(string[] args)
        {
            URLPool urlPool = new URLPool();
            
            Producer producer = new Producer(urlPool);

            Consumer consumer = new Consumer(urlPool);

            consumer.start();



            Console.WriteLine("over...");
            Console.ReadKey();

        }
    }
}
