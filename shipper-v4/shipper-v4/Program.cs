﻿/*
 * Grading ID: E3780
 * Program: 1B
 * Due Date: September 29 2020
 * Course: CIS 200-76
 * Description: Includes sample data to test the Address and children of the Parcel class.
 */

using System;
using System.Collections.Generic;

namespace shipper_v4
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of packages are created and displayed
        static void Main(string[] args)
        {
            // List of sample addresses
            List<Address> homes = new List<Address>
            {
                new Address("Helen C. Bice", "1163 Thompson Drive", "El Sobrante", "CA", 94803),
                new Address("Teresa T. Johnson", "3542 Farland Street", "Apt 101", "Westborough", "MA", 01581),
                new Address("Troy H. Thomas", "1299 Saints Alley", "Plant City", "FL", 33564),
                new Address("Susan K. McCrady", "3118 Chenoweth Drive", "Apt B3", "Clarksville", "TN", 37040)
            };

            // List of sample letters using addresses
            List<Package> packages = new List<Package>
            {
                new GroundPackage(homes[0], homes[1], 30, 42, 18, 60),
                new NextDayAirPackage(homes[0], homes[3], 40, 20, 60, 74, 10M),
                new TwoDayAirPackage(homes[2], homes[1], 20, 25, 50, 75, TwoDayAirPackage.Delivery.Early),
                new TwoDayAirPackage(homes[2], homes[3], 40, 40, 20, 76, TwoDayAirPackage.Delivery.Saver),
            };

            Console.WriteLine("Program 1A");

            foreach (Package package in packages)
            {
                Console.WriteLine(package.ToString());
                Console.WriteLine(String.Empty.PadLeft(60, '-'));
            }
        }
    }
}
