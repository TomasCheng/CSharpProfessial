using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FSM12_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一系列字符串(以,分隔),判断里面的标识符：");

            SymbolsTable table = new SymbolsTable();
            //string strIn = Console.ReadLine();

            string strIn = File.ReadAllText("code.txt");

            char[] sep = {'.', ' ','\n'};

            string[] strs = strIn.Split(sep);
            foreach (var str in strs)
            {
                if (SymbolUtils.IsSymbol(str))
                {
                    if (!table.IsExit(str))
                    {
                        table.Add(str);
                    }
                    
                }
            }
            

            File.WriteAllText("symbols.txt", table.PrintSymbols());

            Console.ReadKey();
        }
    }
}
