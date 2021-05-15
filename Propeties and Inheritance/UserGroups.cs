using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class UserGroups
    {
        public static List<Person> userList = new List<Person>();

        //adduser to list - pass itn a person object
        public static void AddUser(Person person)
        {
            userList.Add(person);
            Console.WriteLine("Person added to storage!");
        }

        //search for a specific user
        public static Person GetUser(string sname)
        {
            //loop through the entire list
            foreach (Person p in userList)
            {
                //if an object has a matching name, return it
                if(p.SName == sname)
                {
                    return p;
                }
            }
            //if none is found, return null
            return null;
        }

        //return entire list
        public static List<Person> GetAll()
        {
            return userList;
        }
    }
}
