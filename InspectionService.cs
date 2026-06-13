using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class InspectionService
    {
        internal Vehicle Vehicle;
        internal void InspectVehicle(Vehicle vehicle)
        {
            this.Vehicle = vehicle;

            if (vehicle is null)
            {
                Console.WriteLine("No vehicle provided to inspect.");
                return;
            }

            Console.WriteLine($"Currently inspecting {vehicle.Brand} {vehicle.Model} ({vehicle.Year})");

            vehicle.Start();
            vehicle.Stop();
        }
    }

}
