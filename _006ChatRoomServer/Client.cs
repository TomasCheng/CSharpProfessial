using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006ChatRoomServer
{
    /// <summary>
    /// 用来和客户端通信
    /// </summary>
    class Client
    {
        private Socket clientSocket;

        private Thread t;

        private  byte[] data =new byte[1024];

        public Client(Socket clientSocket)
        {
            this.clientSocket = clientSocket;

            //启动一个线程处理客户端的消息接收
            t = new Thread(ReceiveMessage);
            t.Start();
        }

        private void ReceiveMessage()
        {
            //一直接收客户端的消息
            while (true)
            {
                //接收数据前，判断socket是否断开
                if (clientSocket.Poll(10,SelectMode.SelectRead))
                {
                    //移除这个客户端
                    Program.RemoveNotConnectedClients(this);
                    clientSocket.Close();//关闭这个客户端的链接
                    Console.WriteLine("一个客户端断开了");
                    break;//线程也结束了
                }

                int len = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data,0,len);

                //todo:接收到数据以后，把数据分发到客户端
                //广播消息
                if (message != "")
                {
                    Program.BrocastMessage(message);
                    Console.WriteLine("收到了消息：" + message);
                }
                
            }
            

        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);

        }

        //判断客户端连接是否断开了
        public bool Connected => clientSocket.Connected;
    }
}
