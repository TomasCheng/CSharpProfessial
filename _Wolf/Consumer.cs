using System;
using System.IO;
using System.Net;
using System.Text;
using NSoup.Nodes;
using NSoup.Select;

namespace _Wolf
{
    public class Consumer
    {
        private URLPool urlPool;

        public Consumer(URLPool urlPool)
        {
            this.urlPool = urlPool;
            DirectoryInfo directoryInfo = new DirectoryInfo("downloads");
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }
        }

        public void download(string url)
        {
            WebClient webClient = new WebClient();
            byte[] dataBytes = webClient.DownloadData(url);
            string html = Encoding.UTF8.GetString(dataBytes);
            Document document = NSoup.NSoupClient.Parse(html);
            string title = document.Title;
            title = title.Split(' ')[0];
            if(!(title[0]>='A' && title[0] <= 'Z'))
            {
                return;
            }

            //创建目录
            DirectoryInfo directoryInfo = new DirectoryInfo("downloads" + "\\" + title);
            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }
            //下载种子,合成一个以番号命名的html文件
            Elements elements = document.Select("strong");
            if (elements.Count == 0)
            {
                return;
            }
//            string name = elements[0].Html();
            Element torrent = elements[0].Parents[0];
            string str = torrent.Attr("href");
            str = str.Insert(63, "&amp;");
            Console.WriteLine("正在下载种子文件："+str);           
            HTMLContact htmlContact = new HTMLContact(str);
            FileStream fileStream = new FileStream("downloads" + "\\" + title + "\\" + title + ".html",FileMode.Create);
            dataBytes = Encoding.UTF8.GetBytes(htmlContact.ToString());
            fileStream.Write(dataBytes,0,dataBytes.Length);
            fileStream.Close();
            


            //下载图片
            Elements imgElements = document.Select(".view_image");
            string imgUrl = imgElements[0].Children[0].Attr("src");
            Console.WriteLine("正在下载图片文件：" + imgUrl);
            webClient.DownloadFile(imgUrl, "downloads" + "\\" + title + "\\" + title+".jpg");



        }

        public void start()
        {
            foreach (string url in urlPool.urlList)
            {
                download(url);
            }
        }


    }
}