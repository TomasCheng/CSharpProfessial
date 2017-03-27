namespace _Wolf
{
    public class Producer
    {
        private URLPool urlPool;

        public Producer(URLPool urlPool)
        {
            this.urlPool = urlPool;
            int rootNum = 29338;
            string rootURL = "https://www.yasarang.net/bbs/board.php?bo_table=torrent_jpn1&wr_id=";
            string temp;
            for (int i = 0; i < 100; i++)
            {
                temp = rootURL + (rootNum + i);
                urlPool.putUrl(temp);
            }
        }

        public void putUrl()
        {
            
        }
    }
}