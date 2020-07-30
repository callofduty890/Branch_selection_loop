using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_超人视觉培养学员
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2018;
            int PersonNumber = 200;

            while (PersonNumber<2000)
            {
                PersonNumber = (int)(PersonNumber * (1 + 0.2));
                year++;
            }
            Console.WriteLine("超人视觉到了{0}年 人数达到2000人以上。请称呼罗校长", year);
            Console.ReadKey();
        }
    }
}
