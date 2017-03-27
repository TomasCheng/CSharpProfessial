using System;
using System.Collections.Generic;
using System.Text;

namespace _FSM12_12
{
    public class SymbolsTable
    {
        List<string> symbolList = new List<string>();
        List<int> numList = new List<int>();
        int identifiedNum = 100;
        private int num = 0;
        

        /// <summary>
        /// 向符号表中添加一个符号
        /// </summary>
        /// <param name="symbol"></param>
        public void Add(string symbol)
        {
            symbolList.Add(symbol);
            numList.Add(++identifiedNum);
            num++;
        }

        /// <summary>
        /// 判断符号是否存在符号表中
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public bool IsExit(string symbol)
        {
            if (symbolList.IndexOf(symbol) >= 0)
            {
                return true;
            }
            return false;
        }

        

        public string PrintSymbols()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("符号表中的符号有" + num + "个：\n");
            sb.Append("编号   标识符\n");
            Console.WriteLine("符号表中的符号有{0}个：",num);
            Console.WriteLine("编号   标识符");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(numList[i]+"    "+symbolList[i]);
                sb.Append(numList[i].ToString() + "    " + symbolList[i].ToString() + "\n");
            }
            Console.WriteLine();

            return sb.ToString();



        }
    }
}