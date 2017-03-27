﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AStarDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DateTime beforeTime = System.DateTime.Now;

            

            var mytest = new test();
            //定义出发位置
            var pa = new Point();
            pa.x = 2;
            pa.y = 3;
            //定义目的地
            var pb = new Point();
            pb.x = 8;
            pb.y = 8;

            mytest.FindWay(pa, pb);

            mytest.PrintMap();

            DateTime afterTime = System.DateTime.Now;
            TimeSpan timeSpan = afterTime.Subtract(beforeTime);
            Console.WriteLine("耗时：{0}ms",timeSpan.TotalMilliseconds);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("stopwatch测得耗时：{0}ms",ts.TotalMilliseconds);


            Console.ReadLine();
        }
    }


    internal class test
    {
        //关闭列表
        private readonly List<Point> Close_List = new List<Point>();


        //开启列表
        private readonly List<Point> Open_List = new List<Point>();

        //数组用1表示可通过，0表示障碍物
        private readonly byte[,] R = new byte[10, 10]
        {
            {1, 1, 1, 1, 1, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 1, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 0, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1, 1, 1, 1}
        };

        //从开启列表查找F值最小的节点
        private Point GetMinFFromOpenList()
        {
            Point Pmin = null;
            foreach (var p in Open_List) if (Pmin == null || Pmin.G + Pmin.H > p.G + p.H) Pmin = p;
            return Pmin;
        }

        //判断一个点是否为障碍物
        private bool IsBar(Point p, byte[,] map)
        {
            if (map[p.y, p.x] == 0) return true;
            return false;
        }

        //判断关闭列表是否包含一个坐标的点
        private bool IsInCloseList(int x, int y)
        {
            foreach (var p in Close_List) if (p.x == x && p.y == y) return true;
            return false;
        }

        //从关闭列表返回对应坐标的点
        private Point GetPointFromCloseList(int x, int y)
        {
            foreach (var p in Close_List) if (p.x == x && p.y == y) return p;
            return null;
        }

        //判断开启列表是否包含一个坐标的点
        private bool IsInOpenList(int x, int y)
        {
            foreach (var p in Open_List) if (p.x == x && p.y == y) return true;
            return false;
        }

        //从开启列表返回对应坐标的点
        private Point GetPointFromOpenList(int x, int y)
        {
            foreach (var p in Open_List) if (p.x == x && p.y == y) return p;
            return null;
        }


        //计算某个点的G值
        private int GetG(Point p)
        {
            if (p.father == null) return 0;
            if (p.x == p.father.x || p.y == p.father.y) return p.father.G + 10;
            return p.father.G + 14;
        }

        //计算某个点的H值
        private int GetH(Point p, Point pb)
        {
            return Math.Abs(p.x - pb.x) + Math.Abs(p.y - pb.y);
        }

        //检查当前节点附近的节点
        private void CheckP8(Point p0, byte[,] map, Point pa, ref Point pb)
        {
            for (var xt = p0.x - 1; xt <= p0.x + 1; xt++)
            {
                for (var yt = p0.y - 1; yt <= p0.y + 1; yt++)
                {
                    //排除超过边界和等于自身的点
                    if (xt >= 0 && xt < 10 && yt >= 0 && yt < 10 && !(xt == p0.x && yt == p0.y))
                    {
                        //排除障碍点和关闭列表中的点
                        if (map[yt, xt] != 0 && !IsInCloseList(xt, yt))
                        {
                            if (IsInOpenList(xt, yt))
                            {
                                var pt = GetPointFromOpenList(xt, yt);
                                var G_new = 0;
                                if (p0.x == pt.x || p0.y == pt.y) G_new = p0.G + 10;
                                else G_new = p0.G + 14;
                                if (G_new < pt.G)
                                {
                                    Open_List.Remove(pt);
                                    pt.father = p0;
                                    pt.G = G_new;
                                    Open_List.Add(pt);
                                }
                            }
                            else
                            {
                                //不在开启列表中
                                var pt = new Point();
                                pt.x = xt;
                                pt.y = yt;
                                pt.father = p0;
                                pt.G = GetG(pt);
                                pt.H = GetH(pt, pb);
                                Open_List.Add(pt);
                            }
                        }
                    }
                }
            }
        }


        public void FindWay(Point pa, Point pb)
        {
            Open_List.Add(pa);
            while (!(IsInOpenList(pb.x, pb.y) || Open_List.Count == 0))
            {
                var p0 = GetMinFFromOpenList();
                if (p0 == null) return;
                Open_List.Remove(p0);
                Close_List.Add(p0);
                CheckP8(p0, R, pa, ref pb);
            }


            var p = GetPointFromOpenList(pb.x, pb.y);
            while (p.father != null)
            {
                p = p.father;
                R[p.y, p.x] = 3;
            }
        }

        public void SaveWay(Point pb)
        {
            var p = pb;
            while (p.father != null)
            {
                p = p.father;
                R[p.y, p.x] = 3;
            }
        }

        public void PrintMap()
        {
            for (var a = 0; a < 10; a++)
            {
                for (var b = 0; b < 10; b++)
                {
                    if (R[a, b] == 1) Console.Write("█");
                    else if (R[a, b] == 3) Console.Write("★");
                    else if (R[a, b] == 4) Console.Write("○");

                    else Console.Write("  ");
                }
                Console.Write("\n");
            }
        }
    }

    internal class Point
    {
        public Point father;
        public int G;
        public int H;
        public int x;
        public int y;

        public Point()
        {
        }

        public Point(int x0, int y0, int G0, int H0, Point F)
        {
            x = x0;
            y = y0;
            G = G0;
            H = H0;
            father = F;
        }
    }
}