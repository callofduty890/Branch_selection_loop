using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_IF_else_if_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入账号密码
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();

            //第一种情况：账号密码都正确
            if (name == "admin" && pwd == "88888")
            {
                Console.WriteLine("登录成功");
            }
            else if (name == "admin") //第二种情况：账号正确
            {
                Console.WriteLine("密码错误");
            }
            else //第三种情况：账号 密码 错误
            {
                Console.WriteLine("请检查账号");
            }
        }
    }
}
