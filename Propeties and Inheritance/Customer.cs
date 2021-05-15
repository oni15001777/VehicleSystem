using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    class Customer : Person
    {
        public Customer()
        {
        }

        public Customer(string FName, string SName, string Address, string Phone, DateTime DOB, string Password) : base(FName, SName, Address, Phone, DOB, Password)
        {
            this.role = "Customer";
        }
    }
}
