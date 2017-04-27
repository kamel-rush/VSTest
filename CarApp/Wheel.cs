using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Wheel
    {
        //
        private String type;

        private float diameter;

        public Wheel(string type, float diameter)
        {
            this.type = type;
            this.diameter = diameter;
        }

        public Wheel()
        {
            type = "Generic Wheel";
            Diameter = 10.0f;
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public float Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                diameter = value;
            }
        }
    }
}
