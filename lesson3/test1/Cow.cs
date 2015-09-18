using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Cow:Animal
    {
        public Cow (String name):base(name)
        {

        }

        public Cow() { }

        public override string getSound()
        {
            return "哞";
        }
    }
}
