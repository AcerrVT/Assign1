using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace Assign1
{
    internal class Program
    {
        static void Main()
        {
            Garage garage = new Garage("The Best Garage", "600 Rue St Catherine", "Montreal", "J5B7Y6");

            // Creating parking spots
            ParkingSpot spot1 = new ParkingSpot(1, false);
            ParkingSpot spot2 = new ParkingSpot(2, false);
            ParkingSpot spot3 = new ParkingSpot(3, false);
            ParkingSpot spot4 = new ParkingSpot(4, false);
            ParkingSpot spot5 = new ParkingSpot(5, false);

            // Adding parking spots to the garage
            garage.AddParkingSpot(spot1);
            garage.AddParkingSpot(spot2);
            garage.AddParkingSpot(spot3);
            garage.AddParkingSpot(spot4);
            garage.AddParkingSpot(spot5);


            // Creating car
            Car car = new Car("Toyota", "Camry", 2020, 4);

            // Creating Truck
            Truck truck = new Truck("Ford", "F-150", 2019, 1000);

            // Creating Motorcycles
            Motorcycle motorcycle1 = new Motorcycle("Harley-Davidson", "Street 750", 2018, false);

            // Creating drivers
            Driver driver1 = new Driver("Alice", 21, "D1234567");
            Driver driver2 = new Driver("Bob", 18, "D2345678");
            Driver driver3 = new Driver("Charlie", 25, "D3456789");

            garage.AddDriver(driver1);
            garage.AddDriver(driver2);
            garage.AddDriver(driver3);


            InspectionService inspectionService1 = new InspectionService();

            //Inspecting car:
            inspectionService1.InspectVehicle(car);
            Console.WriteLine();

            inspectionService1.InspectVehicle(truck);
            Console.WriteLine();

            inspectionService1.InspectVehicle(motorcycle1);
            Console.WriteLine();

            // Generating report
            ReportGenerator report = new ReportGenerator(garage);
            report.GenerateGarageReport(garage);

        }
    }
}
