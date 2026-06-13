using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Garage
    {
        // Attributes
        internal string Name;
        internal Address Address;
        internal List<ParkingSpot> ParkingSpots = new List<ParkingSpot>();
        internal List<Driver> Drivers = new List<Driver>();

        // Constructor
        internal Garage(string name, string street, string city, string postalcode)
        {
            this.Name = name;
            this.Address = new Address(street, city, postalcode);
        }

        internal void AddParkingSpot(ParkingSpot spot) // Assumed internal and void characteristics
        {
            ParkingSpots.Add(spot);
        }

        internal void DisplayGarageInfo() // Assumed internal and void characteristics
        {
            Console.WriteLine($"Garage: {Name}");
            Console.WriteLine($"Address: {Address}");
            DisplayDrivers();
            Console.WriteLine("Parking spots:");
            foreach (var spot in ParkingSpots)
            {
                Console.WriteLine($"  Spot {spot.Number}: {(spot.IsOccupied ? "Occupied" : "Available")}");
            }
        }

        internal void AddDriver(Driver driver) // Assumed internal and void characteristics
        {
            Drivers.Add(driver);
        }

        internal void DisplayDrivers() // Assumed internal and void characteristics
        {
            Console.WriteLine("Drivers:");
            foreach (var driver in Drivers)
            {
                Console.WriteLine($"  {driver.Name}, Age: {driver.age}, License: {driver.LicenseNumber}");
            }
        }
    }

}
