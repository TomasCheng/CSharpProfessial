using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LitJson;

namespace _009json操作
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skilllList = new List<Skill>();
            //使用LitJson解析json信息
            //两种引入litJson的方式
            //1.从官网下载
            //2.在项目的引用中，通过NuGet管理器下载安装.dll文件

            //使用JsonMapper来解析json文本

            //jsonData代表一个对象或者数组
//            JsonData data = JsonMapper.ToObject(File.ReadAllText("jsonSkill.txt"));
////            Console.WriteLine(data);
//
//            foreach (JsonData tempData in data)
//            {
//                //通过字符串索引器取得键值对的值
//                JsonData idValue = tempData["id"];
//                JsonData nameValue = tempData["name"];
//                JsonData damageValue = tempData["damage"];
//
//                int id = Int32.Parse(idValue.ToString());
//                int damage = Int32.Parse(damageValue.ToString());
//                string name = nameValue.ToString();
//                Console.WriteLine("id:{0},name:{1},damage:{2}",id,name,damage);
//            }

            
//            //通过泛型解析
//            Skill[] skills = JsonMapper.ToObject<Skill[]>(File.ReadAllText("jsonSkill.txt"));
//
//            //任何使用数组的地方都可以用List代替
//            skilllList = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("jsonSkill.txt"));
//
//            foreach (var skill in skilllList)
//            {
//                Console.WriteLine(skill);
//            }
            
//            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"),12345);
//
//            tcpListener.Start();

            List<Person> personList = new List<Person>();

            personList = JsonMapper.ToObject<List<Person>>(File.ReadAllText("persons.txt"));

            foreach (var person in personList)
            {
                Console.WriteLine(person);

            }

//            string str = JsonMapper.ToJson(personList);
//
//            
//            
//            Console.WriteLine(UnicodeToString(personList[0].name));



//            new Thread(() =>
//            {
//                while (true)
//                {
//                    Console.WriteLine("开始监听");
//                    
//                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
//                    Console.WriteLine("有一个客户端连接上来啦");
//                    new Thread(() =>
//                    {
//                        NetworkStream stream = tcpClient.GetStream();
//                        byte[] dataBytes =Encoding.UTF8.GetBytes(JsonMapper.ToJson(personList));
//                        dataBytes = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, dataBytes);
//                        stream.WriteAsync(dataBytes, 0, dataBytes.Length);
//
//                        stream.Close();
//                    }).Start();
//                }
//                
//
//
//            }).Start();



            Console.ReadKey();

        }
        public static string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 6;
            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 6).Substring(2);
                src = src.Substring(6);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }
    }
}
