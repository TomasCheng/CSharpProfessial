using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006SocketServerUDP
{
    class Program
    {

        public static Socket udpServer;
        static void Main(string[] args)
        {
            //创建udp的socket
            udpServer = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

            //绑定ip和端口号
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"),7789 ));

            //接收数据
            //将线程设为后台线程
            new Thread(ReceiveMEssage).Start();

//            udpServer.Close();
//            Console.WriteLine("关闭socket");
//            Console.ReadKey();
            
            
            

        }

        public static void ReceiveMEssage()
        {
            while (true)
            {
                byte[] dataBytes = new byte[1024];
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                //把数据的来源（ip：port）放到第二个参数上,注意要加上ref关键字
                int len = udpServer.ReceiveFrom(dataBytes, ref remoteEndPoint);

                string message = Encoding.UTF8.GetString(dataBytes, 0, len);

                var ipEndPoint = remoteEndPoint as IPEndPoint;
                if (ipEndPoint != null)
                    Console.WriteLine("从 {0}：{1} 接收到了数据:{2}", ipEndPoint.Address, ipEndPoint.Port, message);
            }

            
        }
    }
}
