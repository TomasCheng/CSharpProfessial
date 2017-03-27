using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _001Regex
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //            string s = "i am a blue cat\nsss";
            /// 定位元字符
            //            Console.WriteLine(Regex.Replace(s, "^", "开始:"));
            //            Console.WriteLine(Regex.Replace(s,"$","mmmmm"));
            //            Console.WriteLine(Regex.);
            //            string s = Console.ReadLine();
            //            bool isMatch = true;
            //            for (int i = 0; i < s.Length; i++)
            //            {
            //                if (s[i] < '0' || s[i] > '9')
            //                {
            //                    isMatch = false;
            //                    break;
            //                }
            //            }
            //            if (isMatch)
            //            {
            //                Console.WriteLine("hefa");
            //            }
            //            else
            //            {
            //                Console.WriteLine("xxx");
            //            }
            //            string s = Console.ReadLine();
            //            string pattern = @"^\d*$";//正则表达式
            //            string pattern = @"^\W*$";
            //            Console.WriteLine(s != null && Regex.IsMatch(s, pattern));

            //            string s = "i am a cat!";
            //            string regex = @"[^abc]";
            //            Console.WriteLine(Regex.Replace(s,regex,"*"));
            //            Console.WriteLine(s);

//            string s = "15616231";
//            string regex = @"[^\d{5,12}]$";
//            Console.WriteLine(Regex.IsMatch(s,regex));
//            Console.WriteLine(Regex.Replace(s, regex, "*"));
//            Console.WriteLine(s);

//            string s = "sadh-=0=0=1231adfo分期服务器";
//            string regex = @"\d|[a-z]";
//            MatchCollection col = Regex.Matches(s, regex);
//            foreach (var m in col)
//            {
//                Console.WriteLine(m);
//                
//            }
//
//            string names = "hah.sda,da|da.asda";
////            string pattern = @"[.,|.]";
//
//            string pattern = @".|,|\|";
//            string[] s=Regex.Split(names, pattern);
//            foreach (var s1 in s)
//            {
//                Console.WriteLine(s1);
//            }

//            string str = @"([0-254].){3}[0-254]";
//            Console.WriteLine(Regex.IsMatch("1.2.3.5",str));
//            Console.WriteLine(Regex.IsMatch("1.2.3.5.",str));
//            Console.WriteLine(Regex.IsMatch("1.2.3321.5.",str));


        }
    }
}
