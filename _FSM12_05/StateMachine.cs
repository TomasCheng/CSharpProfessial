using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FSM12_05
{
    //判断一个数是不是无符号实数
    class StateMachine
    {
        private int STATE_NUM;
        private int CHAR_NUM;
        private int Diget;
        private int Dot;
       

        private int[,] STATE;
        private bool[] StateResult;

        private char[] buffer;
        private int index_now;

        public void Init()
        {
            STATE_NUM = 4;
            CHAR_NUM = 2;
            Diget = 0;
            Dot = 1;
            STATE = new int[, ] {{1, -1}, {1, 2}, {3, -1}, {3, -1}};
            StateResult =new bool[] {false,true,false,true};
            index_now = 0;
            Console.WriteLine("输入一个字符串以#结束，判断是不是无符号实数：");
        }

        public void ReadLine()
        {
            string temp = Console.ReadLine();
            temp += "#";
            buffer = temp.ToCharArray();
        }

        public char GetChar()
        {
            char c = buffer[index_now];
            index_now++;

            return c;

        }

        public bool Run()
        {
            int S = 0;
            char c;
            while ((c=GetChar())!='#')
            {
                if (c >= '0' && c <= '9')
                {
                    S = STATE[S,Diget];
                    if (S==-1)
                    {
                        break;
                    }
                }
                else if(c=='.')
                {
                    S = STATE[S, Dot];
                    if (S == -1)
                    {
                        break;
                    }
                }
                else
                {
                    return false;//非法字符
                }
            }
            if (S == -1)
            {
                return false;//非法状态
            }
            return StateResult[S];//返回最后的状态
        }

        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine();
            while (true)
            {
                machine.Init();
                machine.ReadLine();
                Console.WriteLine(machine.Run() ? "OK\n" : "Error\n");
            }
        }
    }
}
