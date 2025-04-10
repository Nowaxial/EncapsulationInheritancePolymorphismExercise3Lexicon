using System.Text;
using VehicleManager.Errors;
using VehicleManager.Vehicles;

namespace VehicleManager;

internal class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        var handler = new VehicleHandler();
        bool isRunning = true;


        while (isRunning)
    {
        Console.WriteLine("\n===== Vehicle System =====");
        Console.WriteLine("1. Add New Vehicle");
        Console.WriteLine("2. List All Vehicles");
        Console.WriteLine("3. Display System Errors (Part 2)");
        Console.WriteLine("4. Run Vechicle Simulation");
        Console.WriteLine("0. Exit");
        Console.Write("Select option: ");

        switch (Console.ReadLine())
        {
            case "1": AddVehicle(handler); break;
            case "2": handler.ListVehicles(); break;
            case "3": ; break;
            case "0": return;
            default: Console.WriteLine("Invalid option"); break;
        }
    }
}

    static void AddVehicle(VehicleHandler handler)
    {

        try
        {
            Console.Write("Ange typ : (Car/Truck/Motorcycle/ElectricScooter): ");
            string type = Console.ReadLine()!;

            Vehicle vehicle = type?.ToLowerInvariant() switch
            {
                "car" => new Car(),
                "truck" => new Truck(),
                "motorcycle" => new Motorcycle(),
                "electricscooter" => new ElectricScooter(),
                _ => throw new ArgumentException("Invalid vehicle type!")
            };

            Console.Write("Brand: ");
            vehicle.Brand = Console.ReadLine()!;
            Console.Write("Model: ");
            vehicle.Model = Console.ReadLine()!;
            Console.Write("Year: ");
            vehicle.Year = int.Parse(Console.ReadLine()!);
            Console.Write("Weight (kg): ");
            vehicle.Weight = double.Parse(Console.ReadLine()!);

            if (vehicle is Car car)
            {
                car.SeatsInVehicle = 5;
            }

            else if (vehicle is Truck truck)
            {
                Console.Write("Cargo Capacity (kg): ");
                truck.CargoCapacity = double.Parse(Console.ReadLine()!);
            }

            handler.AddVehicle(vehicle);
            Console.WriteLine("Fordonet skapat!");
        }
        catch (Exception exeption)
        {
            Console.WriteLine($"❌ Error: {exeption.Message!}");
        }

    }

   
}
