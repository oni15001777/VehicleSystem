using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public static class CLI
    {

        //login
        public static void Login()
        {

            //request username/surname and password
            Console.WriteLine("Enter surname: ");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pw = Console.ReadLine();



            //search the staff/customer utility for the object
            Person currentUser = UserGroups.GetUser(sname);



            //check password and  check if a user is found
            if (currentUser != null && Authenticator.Authenticate(currentUser, pw))
            {
                if (currentUser.role == "Staff")
                {
                    StaffMenu();
                }
                else if (currentUser.role == "Customer")
                {
                    CustomerMenu();
                }
            }
            else
            {
                Console.WriteLine("Incorrect Credentials");
            }


            
        }

        //customer menu
        public static void CustomerMenu()
        {
            Console.WriteLine("Welcome to the Customer Menu");
        }

        //staff menu
        public static void StaffMenu()
        {
            Console.WriteLine("Welcome to the Staff Menu");
            //show menu options such as search cars etc.
            SearchCars();
        }


        //all users option
        public static void SearchCars()
        {
            //PrintAllCars();
            Console.WriteLine("Search by Reg - Enter Reg:");
            string criteria = Console.ReadLine();

            Car result = CarUtility.SearchCar(criteria);

            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine("Not matching cars found!");
            }
        }


        //staff only options

    }
}
