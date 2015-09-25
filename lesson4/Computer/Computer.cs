using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Computer
    {
        public double firstNum, secondNum;
        public Char operate;

        public void setFirstNum(double Num)
        {

            this.firstNum = Num;
        }
        public void setSecondNum(double Num)
        {
            this.secondNum = Num;
        }

        public void compute ()
        {
            switch(operate)
            {
                case '+':
                {
                        Console.WriteLine(firstNum + secondNum);
                        break;
                }
                case '-':
                    {
                        Console.WriteLine(firstNum - secondNum);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(firstNum * secondNum);
                        break;
                    }
                case '/':
                    {
                        if(secondNum == 0)
                        {
                            Console.WriteLine("数值不合法");
                            break;
                        } else
                        {
                            Console.WriteLine(firstNum / secondNum);
                        }
                        break;
                    }
            }

        }
    }
}
