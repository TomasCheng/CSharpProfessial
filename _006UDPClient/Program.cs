using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _006UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient，绑定Ip和端口号          服务器都是要绑定Ip和端口号的，不管哪个协议
            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("127.0.0.1"),7788));


            while (true)
            {
                //接收数据
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref remoteIpEndPoint);//通过参数知道发来数据的客户端的信息

                string message = Encoding.UTF8.GetString(data);

                Console.WriteLine(message);
            }
            

            udpClient.Close();

            Console.ReadKey();

        }
    }
}
