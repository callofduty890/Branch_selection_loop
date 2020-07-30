using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_200到300之间的整数偶数奇数各自的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 200;
            int Sum = 0, eSum=0, oSum = 0;

            while (Num<=300)
            {
                //Console.WriteLine(Num);

                if (Num % 2 == 0)//偶数
                {
                    eSum += Num;
                }
                else //奇数
                {
                    oSum += Num;
                }
                Sum += Num;//所有整数的和
                Num++; //自增
            }
            Console.WriteLine("200到300之间的整数和是{0}，偶数和{1}，奇数和{2}", Sum, eSum, oSum);
            Console.ReadKey();

        }
    }
}
