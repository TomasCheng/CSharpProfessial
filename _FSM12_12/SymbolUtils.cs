namespace _FSM12_12
{
    public class SymbolUtils
    {
        /// <summary>
        /// 判断一个字符串是否是合法的标识符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsSymbol(string str)
        {
            int[,] STATE = new int[,] { {1,-1,1}, {1,1,1} };
            bool[] Result = new[] {false, true};
            int CHAR = 0;
            int DIGET = 1;
            int UNDERLINE = 2;

            int S = 0;//表示当前状态
            char[] chs = str.ToCharArray();
            foreach (var ch in chs)
            {
                if ((ch >='a'&& ch<='z')||(ch >='A' && ch <='Z'))
                {
                    S = STATE[S, CHAR];
                    if (S == -1)
                    {
                        break;
                    }
                }else if (ch>='0'&&ch<='9')
                {
                    S = STATE[S, DIGET];
                    if (S == -1)
                    {
                        break;
                    }
                }
                else if (ch == '_')
                {
                    S = STATE[S, UNDERLINE];
                    if (S == -1)
                    {
                        break;
                    }
                }
                else
                {
                    return false;
                }
            }
            if (S == -1)
            {
                return false;//非法状态
            }
            return Result[S];//返回最后的状态


        }
    }
}