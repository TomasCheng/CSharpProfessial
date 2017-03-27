using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _008xml解析技能信息
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("SkillInfo.xml");
            XmlNode rootNode = xmlDocument.FirstChild.NextSibling.FirstChild;
            XmlNodeList nodeList = rootNode.ChildNodes;
            //遍历每个node获得skill
            foreach (XmlNode node in nodeList)
            {
                Skill skill = new Skill();
                XmlAttributeCollection xmlAttributeCollection = node.Attributes;
                //读取节点的属性值
                foreach (XmlAttribute xmlAttribute  in xmlAttributeCollection)
                {
                    switch (xmlAttribute.Name)
                    {
                        case "SkillID":
                        {
                            skill.SkillId = Int32.Parse(xmlAttribute.Value);
                                break;
                        }
                        case "SkillEngName":
                        {
                            skill.SkillEngName = xmlAttribute.Value;
                                break;
                        }
                        case "TriggerType":
                        {
                            skill.TriggerType = Int32.Parse(xmlAttribute.Value);
                                break;
                        }
                        case "ImageFile":
                        {
                            skill.ImageFile = xmlAttribute.Value;
                                break;
                        }
                        case "AvailableRace":
                        {
                            skill.AvailableRace = Int32.Parse(xmlAttribute.Value);
                                break;
                        }
                    }
                }
                //读取子节点的值
                XmlNode nameNode = node.FirstChild;
                skill.Name = nameNode.InnerText;

                //将读取到的技能放入集合中
                skillList.Add(skill);
                
            }

            StreamWriter streamWriter = new StreamWriter("skillList.txt");
            foreach (var skill in skillList)
            {
                Console.WriteLine(skill);
                streamWriter.WriteLine(skill);
            }
            streamWriter.Close();



            Console.ReadKey();




        }
    }
}
