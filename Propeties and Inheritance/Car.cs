using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class Car:Vehicle
    {
        private int doorCount;

        public Car()
        {

        }

        public Car(string Make, string Model, string Registration, string Colour, Person Owner, int DoorCount):base(Make, Model, Registration, Colour, Owner)
        {
            this.doorCount = DoorCount;
        }

        public override string ToString()
        {
            return $"Vehicle Type: Car\nRegistration: {Registration}\nDoors: {doorCount}\nOwner: {Owner}";
        }
    }
}
