using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_IF语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //接收用户输入上课时间，如果120分钟就休息一下
            //1.接受用户输入信息
            Console.WriteLine("请输入您的学习时间");
            int mins = Convert.ToInt32(Console.ReadLine());
            //2.使用> 判断是否达到时间返回真假
            bool min = mins>120;

            //3.输入结构
            if (min)
            {
                Console.WriteLine("好了，同学们下课休息一下");
            }
            else
            {
                Console.WriteLine("同学请坚持一下,胜利就在眼前");
            }



        }
    }
}
