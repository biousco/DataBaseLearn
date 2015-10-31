using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入light类型(tube/bulb注意小写)：");
            
                string light = Console.ReadLine();
                LightFactory fc = new LightFactory();
                Light l = fc.ProductLight(light);
                l.Off();
                l.On();
                Console.ReadLine();
            
        }
    }
}
