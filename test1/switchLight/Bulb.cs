using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLight
{
    class Bulb :Light
    {
        public override void on ()
        {
            Console.WriteLine("Bulb Light is Turned on");
        }

        public override void off()
        {
            Console.WriteLine("Bulb Light is Turned off");
        }
    }
}
