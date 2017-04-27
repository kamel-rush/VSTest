using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Door
    {

        private String type;
        private String manufacturer;

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

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public Door(string type, string manufacturer)
        {
            this.Type = type;
            this.Manufacturer = manufacturer;
        }
        public Door()
        {
            Type = "Generic Wheel";
            Manufacturer = "Not Set";
        }
    }
}
