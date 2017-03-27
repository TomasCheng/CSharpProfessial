using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NSoup.Nodes;
using NSoup.Select;

namespace _011网络爬虫Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();

            webClient.DownloadFile("http://neihanshequ.com/", "a.html");

            string html = File.ReadAllText("a.html");

            Document doc = NSoup.NSoupClient.Parse(html);

            Console.WriteLine(doc.Title);

            

            Elements links = doc.Select("h1[class]");
            StreamWriter streamWriter = new StreamWriter("jokes.txt");
            foreach (Element element in links)
            {
                Console.WriteLine(element.Children[0].Html());
                streamWriter.WriteLine(element.Children[0].Html()+"\n\n");
                
            }
            streamWriter.Close();


            //            MatchCollection matchCollection = Regex.Matches(html, @"^(<p>)\s*.*\s*(</p>)$");
            //
            //            foreach (Match match in matchCollection)
            //            {
            //                string s = match.Value;
            //                Console.WriteLine(s);
            //            }

            Console.WriteLine("over...");
            Console.ReadKey();
        }
    }
}
