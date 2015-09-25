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
            Computer computer = new Computer();
            computer.firstNum = 15;
            computer.secondNum = 20;
            computer.operate = '*';
            computer.compute();
            Console.ReadLine();
        }
    }
}
