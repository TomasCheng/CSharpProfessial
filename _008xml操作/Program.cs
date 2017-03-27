using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _008xml操作
{
    class Program
    {

        static void Main(string[] args)
        {
            //创建技能信息集合,存储获取到的信息
            List<Skill> skillList = new List<Skill>();

            //xmldocument专门用来解析xml文档的
            XmlDocument xmlDoc = new XmlDocument();

            //加载文档
            //            xmlDoc.Load("skillInfo.xml");
            //直接加载一个xml格式的字符串
            xmlDoc.LoadXml(File.ReadAllText("skillInfo.xml"));


            //得到根节点
            XmlNode rootNode = xmlDoc.FirstChild.NextSibling;

            //获取当前节点下的所有子节点的集合
            XmlNodeList nodeList = rootNode.ChildNodes;

            foreach (XmlNode node in nodeList)
            {
                XmlNodeList fieldNodeList = node.ChildNodes;//获取到skill节点下面的所有节点



                Skill skill = new Skill();

                foreach (XmlNode fieldNode in fieldNodeList)
                {

                    //通过name属性，获取到节点的名字                   
                    switch (fieldNode.Name)
                    {
                        case "id":
                            {

                                skill.Id = Int32.Parse(fieldNode.InnerText);
                                break;
                            }
                        case "name":
                            {
                                skill.Name = fieldNode.InnerText;
                                if (fieldNode.Attributes != null) skill.Lang = fieldNode.Attributes[0].Value;
                                break;
                            }
                        case "damage":
                            {
                                skill.Damage = Int32.Parse(fieldNode.InnerText);
                                break;
                            }
                    }

                }
                skillList.Add(skill);
            }

            foreach (var s in skillList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
