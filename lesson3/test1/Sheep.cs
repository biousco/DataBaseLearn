using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Sheep:Animal
    {
        public Sheep(String name):base(name)
        {

        }

        public Sheep() { }

        public override string getSound()
        {
            return "咩";
        }
    }
}
