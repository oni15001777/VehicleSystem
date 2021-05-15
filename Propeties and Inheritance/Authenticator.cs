using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public static class Authenticator
    {

        public static bool Authenticate(Person p, string pw)
        {
            //write authentication logic here
            if (p.Password == pw)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
