using System;
using System.Collections.Generic;
using System.Text;

namespace Propeties_and_Inheritance
{
    public static class CarUtility
    {
        //created a list to store cars
        public static List<Car> carStorage = new List<Car>();



        //add a car to the list
        public static void AddCar(Car car)
        {
            carStorage.Add(car);
            Console.WriteLine("Car added to storage!");
        }

        //get all car data as a string output
        public static void PrintAllCars()
        {
            foreach(Car car in carStorage)
            {
                Console.WriteLine(car.ToString());
            }
        }

        //search for a vehicle
        public static Car SearchCar(string criteria)
        {
            foreach (Car car in carStorage)
            {
                if (car.Registration == criteria)
                {
                    return car;
                }
            }

            return null;   
        }



    }
}
