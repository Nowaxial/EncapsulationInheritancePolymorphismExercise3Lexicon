using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles;

public class VehicleHandler
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ListVehicles()
    {
        if (!vehicles.Any())
        {
            Console.WriteLine("No vehicles in system");
            return;
        }

        Console.WriteLine("\n===== Vehicle List =====");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"\n{vehicle.Stats()}");
            Console.WriteLine($"🔧 {vehicle.StartEngine()}");

            if (vehicle is ICleanable cleanable)
            {
                Console.Write("🧼 Cleaning: ");
                cleanable.Clean();
            }
        }
    }

}
