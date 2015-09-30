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
                switch (operate)
                {
                    case "+":
                        {
                            OperationAddFactory operation = new OperationAddFactory();
                            oper = operation.createOperation();
                  
                            break;
                        }
                    case "-":
                        {
                            OperationSubFactory operation = new OperationSubFactory();
                            oper = operation.createOperation();
                            break;
                        }
                    case "*":
                        {
                            OperationMulFactory operation = new OperationMulFactory();
                            oper = operation.createOperation();
                            break;
                        }
                    case "/":
                        {
                            OperationDivFactory operation = new OperationDivFactory();
                            oper = operation.createOperation();
                            break;
                        }
                    case "sqrt":
                        {
                            OperationSqrtFactory operation = new OperationSqrtFactory();
                            oper = operation.createOperation();
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
