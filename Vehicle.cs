using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Vehicle
    {
        internal string Brand;
        internal string Model;
        internal int Year;

        internal Vehicle(string Brand, string Model, int year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = year;
        }

        internal void Start()
        {
            Console.WriteLine($"The {Brand} {Model} {Year} car has started.");
        }

        internal void Stop()
        {
            Console.WriteLine($"The {Brand} {Model} {Year} car is stopped.");
        }
    }

}
