using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _006Socket
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.创建socket                地址类型                    流               协议
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);

            //2.绑定ip和端口号
            IPAddress ipAddress = new IPAddress(new byte[]{ 127,0,0,1 });//对ip地址的封装
            EndPoint point = new IPEndPoint(ipAddress,12345);//IPEndPoint是对ip和端口号封装的一个类，endpoint是抽象类
            tcpSocket.Bind(point);//向操作系统申请一个可用的ip和端口号，用来做通信

            Console.WriteLine("开始监听");
            //3.开始监听,等待客户端连接
            tcpSocket.Listen(100);

            //暂停当前线程，直到有一个客户端连接过来，进行下面的代码
            Socket clientSocket = tcpSocket.Accept();

            //使用返回的socket跟客户端通信
//            string msg = "abc我";
//            byte[] data =  Encoding.UTF8.GetBytes(msg);//将字符串转化为字节数组
//
//            foreach (var b in data)
//            {
//                Console.Write(b + " ");
//            }
//
//            clientSocket.Send(data);

            while (true)
            {
                if (clientSocket.Poll(10,SelectMode.SelectRead))
                {
                    break;
                }
                byte[] dataBytes = new byte[1024];
                int len = clientSocket.Receive(dataBytes);
                Console.WriteLine("服务器收到：" + Encoding.UTF8.GetString(dataBytes, 0, len));
            }
            
            Console.WriteLine("服务器关闭");
            clientSocket.Close();
            tcpSocket.Close();
           

            Console.ReadKey();

        }
    }
}
