using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest1
{
    class Bulb:Light
    {
        public override void On()
        {
            Console.WriteLine("Bulb Light is Turned on");
            
        }
        public override void Off()
        {
            Console.WriteLine("Bulb Light is Turned off");
        }
    }
}
