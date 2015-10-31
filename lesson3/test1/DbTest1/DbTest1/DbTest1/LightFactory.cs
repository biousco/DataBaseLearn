using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest1
{
    class LightFactory
    {
        public Light ProductLight(string str){
            Light light=null;
            switch (str)
            {
                case "tube":
                    light = new Tube();
                    break;
                case "bulb":
                    light = new Bulb();
                    break;
               

            }
            return light;
        }
    }
}
