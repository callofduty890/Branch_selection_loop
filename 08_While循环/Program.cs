using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_While循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n<100)
            {
                Console.WriteLine("第{0}次说：视觉一定要坚持学习",n);
                n++;
            }
            Console.ReadKey();

        }
    }
}
