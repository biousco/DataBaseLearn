using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLight
{
    class Tube : Light
    {
        public override void on()
        {
            Console.WriteLine("Tube Light is Turned on");
        }

        public override void off()
        {
            Console.WriteLine("Tube Light is Turned off");
        }
    }
}
