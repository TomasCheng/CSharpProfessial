using System.Collections.Generic;

namespace _Wolf
{
    public class URLPool
    {
        public List<string> urlList = new List<string>();
        

        public string getUrl()
        {
            return urlList[0];
        }

        public void removeUrl(string url)
        {
            urlList.Remove(url);
        }

        public void putUrl(string url)
        {
            urlList.Add(url);
        }
    }
}