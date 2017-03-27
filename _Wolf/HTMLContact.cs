namespace _Wolf
{
    /// <summary>
    /// 根据指定的链接生成html字符串
    /// </summary>
    public class HTMLContact
    {
        private string beforeStr;
        private string hrefStr;
        private string afterStr;

        private string html;

        public HTMLContact(string href)
        {
            beforeStr = "<!doctype html><html lang = \"ko\"><head><meta http - equiv = \"X-UA-Compatible\" content = \"IE=10,chrome=1\" ><title> Go Gor Downloading</title><script language = \"javascript\" type = \"text/javascript\">window.location.href = '";
            afterStr = "';</script></head><body></body></html>";
            hrefStr = href;
            html = beforeStr + hrefStr + afterStr;
        }

        public override string ToString()
        {
            return html;
        }
    }
}