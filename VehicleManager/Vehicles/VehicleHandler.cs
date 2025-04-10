using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles;

public class VehicleHandler
{
    private readonly List<Vehicle> vehicles = new();
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ListVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Stats());
            Console.WriteLine(vehicle.StartEngine());

            if (vehicle is ICleanable cleanable)
            {
                Console.Write("🧼 Cleaning: ");
                cleanable.Clean();
            }      
        }
    }
}
