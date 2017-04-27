using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car
    {

        private String color;

        public Wheel[] carWheels;

        public Door[] carDoors;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Car()
        {
            carWheels = new Wheel[4];

            carDoors = new Door[4];

            for (int i = 0; i < carWheels.Length; i++)
                carWheels[i] = new Wheel();

            for (int i = 0; i < carDoors.Length; i++)
                carDoors[i] = new Door();
        }

        public Car(int wheelCount, int doorCount)
        {

            carWheels = new Wheel[wheelCount];

            carDoors = new Door[doorCount];

            for (int i = 0; i < carWheels.Length; i++)
                carWheels[i] = new Wheel();

            for (int i = 0; i < carDoors.Length; i++)
                carDoors[i] = new Door();
        }

    }

}
