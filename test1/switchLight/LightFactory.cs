using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchLight
{
    class LightFactory
    {
        public Light getLight(String type)
        {
            Light light = null;
            switch (type)
            {
                case "bulb":
                    {
                        light = new Bulb();
                        break;
                    }
                case "tube":
                    {
                        light = new Tube();
                        break;
                    }
            }
            return light;

        }
    }
}
