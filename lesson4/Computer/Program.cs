using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入数字a：");
                string aNum = Console.ReadLine();
                Console.WriteLine("输入运算符号：");
                string operate = Console.ReadLine();
                Console.WriteLine("输入数字b：");
                string bNum = Console.ReadLine();
                string res = "";

                Operation oper;
                oper = OperationFactory.createOperate(operate);
                oper.NumA = Convert.ToDouble(aNum);
                oper.NumB = Convert.ToDouble(bNum);
                res = Convert.ToString(oper.GetResult());
                Console.WriteLine("输出结果是：");
                Console.WriteLine(res);
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine("输入有错误:" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
