using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_if_else练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入最后一场考试，如果小于60分不及格请重新学习
            //1.接受用户输入的考试成绩
            Console.WriteLine("请输入您的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            //2.判断成绩，输出信息：1.恭喜通过考试 2.建议重新学习
            //60一下不及格 60-70及格 70-80中等 80-90优秀 90->蒂花之秀
            if (score>=60)
            {
                Console.WriteLine("恭喜通过考试");
                if (score >= 90)
                {
                    Console.WriteLine("您的考试成绩：天秀");
                }
            }
            else
            {
                Console.WriteLine("建议重新学习");
            }
        }
    }
}
