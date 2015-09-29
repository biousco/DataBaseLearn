using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class Computer
    {
        public static double getResult (double firstNum, string operate, double secondNum)
        {
            double result = 0;
            switch(operate)
            {
                case "+":
                    {
                        result = firstNum + secondNum;
                        break;
                    }
                case "-":
                    {
                        result = firstNum - secondNum;
                        break;
                    }
                case "*":
                    {
                        result = firstNum * secondNum;
                        break;
                    }
                case "/":
                    {
                        result = firstNum / secondNum;
                        break;
                    }
            }
            return result;
        }
    }
}
