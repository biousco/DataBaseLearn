using Computer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory
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
                OperationAddFactory operation = new OperationAddFactory();
                oper = operation.createOperation();
                switch (operate)
                {
                    case "+":
                        {
                            OperationAddFactory operation1 = new OperationAddFactory();
                            oper = operation1.createOperation();
                            break;
                        }
                    case "-":
                        {
                            OperationSubFactory operation1 = new OperationSubFactory();
                            oper = operation1.createOperation();
                            break;
                        }
                    case "*":
                        {
                            OperationMulFactory operation1 = new OperationMulFactory();
                            oper = operation1.createOperation();
                            break;
                        }
                    case "/":
                        {
                            OperationDivFactory operation1 = new OperationDivFactory();
                            oper = operation1.createOperation();
                            break;
                        }
                    case "sqrt":
                        {
                            OperationSqrtFactory operation1 = new OperationSqrtFactory();
                            oper = operation1.createOperation();
                            break;
                        }
                }
                oper.NumA = Convert.ToDouble(aNum);
                oper.NumB = Convert.ToDouble(bNum);
                res = Convert.ToString(oper.GetResult());
                Console.WriteLine("输出结果是：");
                Console.WriteLine(res);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("输入有错误:" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
