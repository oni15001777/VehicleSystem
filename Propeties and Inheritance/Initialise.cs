using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public class Initialise
    {
        public static void Init()
        {


            Customer person1 = new Customer("Jhon", "Doe", "123 New String", "11222211112", new DateTime(1980, 10, 05), "xxxx");
            Customer person2 = new Customer("Jason", "Smith", "23 East String", "1232111112", new DateTime(1985, 11, 15), "yyyy");
            Customer person3 = new Customer("Jack", "Rolls", "12 South String", "1122233212", new DateTime(1970, 10, 6), "zzzz");

            Staff staff1 = new Staff("Arnold", "Rolls", "2 South String", "4422233212", new DateTime(1977, 11, 6), "tttt");

            //add initialised user to the usergroup
            UserGroups.AddUser(person1);
            UserGroups.AddUser(person2);
            UserGroups.AddUser(person3);
            UserGroups.AddUser(staff1);

            Car car1 = new Car("Ford", "Fiesta", "YW34ADC", "Blue", person1, 5);
            Car car2 = new Car("Alpha Romeo", "Lux", "ED45FGT", "Silver", person2, 5);
            Car car3 = new Car("Tesla", "Model S", "DD34ADC", "Black", person3, 5);

            //Console.WriteLine(car1.ToString());


            CarUtility.AddCar(car1);
            CarUtility.AddCar(car2);
            CarUtility.AddCar(car3);
        }
    }
}
