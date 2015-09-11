using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("甲方记住牌照号码前两位数字相同");
            Console.WriteLine("乙方记住牌照号码后两位数字相同");
            Console.WriteLine("丙方说车牌号码四位数，恰好是一个整数的平方");
            //平方为4位数的取值范围为32~99
            for(int i = 32; i < 100; i++)
            {
                int first = getMod(i * i);
                if(first >= 0)
                {
                    int last = getMod(first);
                    if(last >= 0)
                    {
                        Console.WriteLine("我夜观天象，发现车牌号码是：" + i * i);
                        break;
                    } else
                    {
                        Console.WriteLine("...");
                        continue;
                    }
                } else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }

        static int getMod(int num)
        {
            int fir1 = num % 10;
            int temp = num / 10;
            int fir2 = temp % 10;
            if(fir1 != fir2)
            {
                return -1;
            } else
            {
                return temp / 10;
            }
        }
    }
}
