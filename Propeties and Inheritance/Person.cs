using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class Person
    {
        //fields
        private string fName;
        private string sName;
        private string address;
        private string phone;
        private DateTime dob;
        public string role;
        private string password;

        //constructors
        public Person()
        {

        }

        public Person(string FName, string SName, string Address, string Phone, DateTime DOB, string Password)
        {
            this.fName = FName;
            this.sName = SName;
            this.address = Address;
            this.phone = Phone;
            this.dob = DOB;
            this.password = Password;
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }


        public override string ToString()
        {
            return $"Owner Name: {fName} {sName}\nOwner Address: {address}\nOwner DOB: {dob}";
        }

        

    }
}
