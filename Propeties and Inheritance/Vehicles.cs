using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class Vehicle
    {
        //fields
        private string make;
        private string model;
        private string registration;
        private string colour;
        private Person owner;

        public Vehicle()
        {

        }

        public Vehicle(string Make, string Model, string Registration, string Colour, Person Owner)
        {
            this.make = Make;
            this.model = Model;
            this.registration = Registration;
            this.colour = Colour;
            this.owner = Owner;
        }

        //set properties
        public string Reg
        {
            get { return registration; }
            set
            {
                if (value != "")
                {
                    registration = value;
                }
                throw new ArgumentException("Registration Field must not be blank!");
            }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public string Registration
        {
            get { return registration; }
            set { registration = value; }
        }
        public Person Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        //Output vehicle details
        public override string ToString()
        {
            return $"Make: {make}\nModel: {model}\nReg: {registration}\nColour: {colour}\nOwner: {owner}";
        }


    }
}
