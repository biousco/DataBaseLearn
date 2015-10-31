using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入bulb或者tube:");
            String lightString;
            lightString = Console.ReadLine();
            LightFactory factory = new LightFactory();
            Light light = factory.getLight(lightString);
            light.on();
            light.off();
            Console.Read();
        }
    }
}
