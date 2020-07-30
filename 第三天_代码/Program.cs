using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第三天_代码
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现几天是几周零几天
            //int days = 46;
            //int week = days / 7;//几周
            //int day = days % 7;//求余 拿到天数
            //Console.WriteLine("{0} 天是{1}周零{2}天",days,week,day);
            //Console.ReadKey();

            //60*60 *24 =86400秒 一天所有的秒
            //3600 * 24
            //创建变量用以接收值
            int seconds = 107653;

            int days = seconds / 86400;//天数
            int secs = seconds % 86400;//求完天数后的剩余秒

            int hours = secs / 3600;//求小时数
            secs = secs % 3600;//求小时后的余数

            int min = secs / 60;//求分钟数
            secs = secs % 60;

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, min, secs);

        }
    }
}
