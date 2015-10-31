using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest1
{
    class Tube:Light
    {
        public override void On()
        {
            Console.WriteLine("Tube Light is Turned on");
        }
        public override void Off()
        {
            Console.WriteLine("Tube Light is Turned off");
        }
    }
}
