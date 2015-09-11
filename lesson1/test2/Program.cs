using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名：");
            String name = Console.ReadLine();
            Console.WriteLine("欢迎你，" + name + "!");
            Console.WriteLine("按下回车键退出...");
            Console.ReadLine();
        }
    }
}
