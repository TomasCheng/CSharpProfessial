using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _006TCPListenner
{
    class Program
    {
        static void Main(string[] args)
        {
            //tcpListenner对socket进行了封装
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"),7790);

            //开始监听
            tcpListener.Start();

            //等待客户端连接
            TcpClient tcpClient = tcpListener.AcceptTcpClient();

            //取得客户端发送来的数据
            NetworkStream networkStream = tcpClient.GetStream();//得到网络流

            //读取数据
            byte[] dataBytes = new byte[1024];//创建数据容器，用来承接数据
            //0表示从数组的那个索引存放数据
            //1024表示最大读取字节数
            while (true)
            {
                if (tcpClient.Connected == false)
                {
                    break;
                }
                int len = networkStream.Read(dataBytes, 0, 1024);//返回实际读取的数据长度

                string message = Encoding.UTF8.GetString(dataBytes, 0, len);
                Console.WriteLine("收到消息：" + message);
            }
            

            Console.ReadKey();

            //释放资源
            networkStream.Close();
            tcpClient.Close();
            tcpListener.Stop();


        }
    }
}
