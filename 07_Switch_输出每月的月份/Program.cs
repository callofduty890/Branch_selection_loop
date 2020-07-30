using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Switch_输出每月的月份
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.输入年份与月份
            Console.WriteLine("请输入您的年份");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入您的月份");
            int Month = Convert.ToInt32(Console.ReadLine());
            //初始化天数
            int Days = 0;

            //使用switch判断月份 大月|小月|2月份 
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Days = 30;
                    break;
                case 2:
                    if (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0)
                    {
                        Days = 29;
                    }
                    else
                    {
                        Days = 28;
                    }
                    break;
                default:
                    Console.WriteLine("输入有误");
                    break;
            }
            Console.WriteLine("{0}年{1}月有{2}天", Year, Month, Days);
            Console.ReadKey();
        }
    }
}
