using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_IF_Else语句练习_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断是否是闰年与不是闰年
            //1.接受用户输入信息
            Console.WriteLine("请输入年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //2.使用> 判断是否达到时间返回真假
            bool isyear = (year%400==0)||(year%4==0&&year%100!=0);

            //3.输入结果
            if (isyear)
            {
                Console.WriteLine("是闰年");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }

        }
    }
}
