using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string switch_on = "A";
            switch (switch_on)
            {
                case "A":
                    Console.WriteLine("喜洋洋");
                    break;
                case "B":
                    Console.WriteLine("灰太狼");
                    break;
                case "C":
                    Console.WriteLine("灰太狼");
                    break;
                default:
                    break;
            }

        }
    }
}
