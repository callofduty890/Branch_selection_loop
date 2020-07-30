using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //请输入您的考试成绩 然后分等级
            Console.WriteLine("请输入考试成绩:");
            int score = Convert.ToInt32(Console.ReadLine());
            //判断成绩等级
            if (score>=90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }

        }
    }
}
