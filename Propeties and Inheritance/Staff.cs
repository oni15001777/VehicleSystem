using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    class Staff : Person
    {
        public Staff()
        {
        }

        public Staff(string FName, string SName, string Address, string Phone, DateTime DOB, string Password) : base(FName, SName, Address, Phone, DOB, Password)
        {
            this.role = "Staff";
        }



    }
}
