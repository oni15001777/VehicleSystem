using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class MotorCycles :Vehicle
    {
        private string testEx;

        public MotorCycles()
        {

        }

        public MotorCycles(Person Owner, string Registration, string Make, string Model,string Colour, string TestEx):base(Make, Model, Registration, Colour, Owner)
        {
            this.testEx = TestEx;
        }
        public override string ToString()
        {
            return $"Vehicle Type: MotorCycle\nRegistration: {Registration}\nDoors: {testEx}\nOwner: {Owner}";
        }
    }
}
