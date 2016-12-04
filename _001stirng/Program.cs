using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001stirng
{
    class Program
    {
        static void Main(string[] args)
        {
//            StringBuilder sb = new StringBuilder("chengliang");
//            string str = " hello,World !";
//            Console.WriteLine(str.CompareTo("adfa"));
//            Console.WriteLine(str.Replace("o","MM"));
//            string[] strs = str.Split(',');
//            foreach (var item in strs)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine(str.Substring(2,5));
//            Console.WriteLine(str.ToUpper());
//            Console.WriteLine(str.Trim());
//            Console.WriteLine(String.Concat("12345",str));
//            
//            Console.WriteLine(String.Format("i am {0} hahah {1}",str,"nnnnnn"));
//
//            Console.WriteLine(str.IndexOf('o',6));
//            char[] m = {'x', 'a', 'd'};
//            Console.WriteLine(str.IndexOfAny(m,0));
//            string[] strs2 = {"aaa", "bbb", "cccc"};
//            Console.WriteLine(String.Join(" xx ",strs2));
                
            StringBuilder sb=new StringBuilder("chengliang");
            sb.Insert(2, "xxx");
            sb.Remove(2, 3);
            sb.Replace("c", "xxxx");
            Console.WriteLine(sb);







        }
    }
}
