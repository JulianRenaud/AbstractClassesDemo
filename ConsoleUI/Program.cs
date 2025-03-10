﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Todo follow all comments!!

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion


            
            var vehicles = new List<Vehicle>();

            var c1 = new Car()
            {
                Year = "2003",
                Make = "Jaguar",
                Model = "X-TYPE",
                MaxPeople = 5
            };

            var m1 = new Motorcycle()
            {
                Year = "2020",
                Make = "Harley-Davidson",
                Model = "Street Glide Special",
                HasStorageBasket = false
            };
            Vehicle v1 = new Car()
            {
                Year = "2023",
                Make = "Jaguar",
                Model = "F-TYPE R",
                MaxPeople = 2
            };
            Vehicle v2 = new Motorcycle()
            {
                Year = "2019",
                Make = "Yamaha",
                Model = "R15",
                HasStorageBasket = false
            };
            

            vehicles.Add(c1);
            vehicles.Add(m1);
            vehicles.Add(v1);
            vehicles.Add(v2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(vehicle.Year);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine("--------------------------------------------------");
            }

            Console.WriteLine("Car one: ");
            c1.DriveAbstract();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Motorcycle one: ");
            m1.DriveAbstract();
            m1.DriveVirtual();
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }
    }
}
