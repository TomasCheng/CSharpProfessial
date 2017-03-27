using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _006ChatRoomServer
{
    class Program
    {
        private static List<Client> clientList = new List<Client>(); //保存所有客户端的信息
        static void Main(string[] args)
        {
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7788));

            serverSocket.Listen(100);
            Console.WriteLine("服务器启动成功");

            while (true)
            {
                Socket clientSocket = serverSocket.Accept();


                Console.WriteLine("一个客户端连接上来了");

                Client client = new Client(clientSocket);//把收发消息的任务交给Client处理

                clientList.Add(client);//管理client
            }
        }

        public static void BrocastMessage(string message)
        {
            //广播消息
            foreach (var client in clientList)
            {
                if (client.Connected)
                {
                    client.SendMessage(message);
                }

            }
        }

        public static void RemoveNotConnectedClients(Client client)
        {
            clientList.Remove(client);
        }
    }
}
