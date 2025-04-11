﻿using VehicleManager.Errors;
using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles;

public class VehicleHandler
{
    private readonly List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle()
    {
        try
        {
            Vehicle vehicle = SelectVehicleType();
            SetCommonVehicleProperties(vehicle);
            SetVehicleSpecificProperties(vehicle);
            vehicles.Add(vehicle);
            Console.WriteLine("\n✅ Vehicle created successfully!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"❌ Validation Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Unexpected Error: {ex.Message}");
        }
    }

    private static Vehicle SelectVehicleType()
    {
        while (true)
        {
            Console.WriteLine("\n=== Select Vehicle Type ===");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Motorcycle");
            Console.WriteLine("4. Electric Scooter");
            Console.Write("Select vehicle type (1-4): ");

            string input = Console.ReadLine()!;

            try
            {
                return input switch
                {
                    "1" => new Car(),
                    "2" => new Truck(),
                    "3" => new Motorcycle(),
                    "4" => new ElectricScooter(),
                    _ => throw new ArgumentException("Invalid selection. Please choose 1-4.")
                };
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"❌ {ex.Message}");
            }
        }
    }

    private static void SetCommonVehicleProperties(Vehicle vehicle)
    {
        try
        {
            Console.Write("Brand: ");
            vehicle.Brand = Console.ReadLine()!;

            Console.Write("Model: ");
            vehicle.Model = Console.ReadLine()!;

            Console.Write("Year: ");
            vehicle.Year = int.Parse(Console.ReadLine()!);

            Console.Write("Weight (kg): ");
            vehicle.Weight = double.Parse(Console.ReadLine()!);
        }
        catch (FormatException)
        {
            throw new ArgumentException("Invalid input format.");
        }
    }

    private static void SetVehicleSpecificProperties(Vehicle vehicle)
    {
        try
        {
            switch (vehicle)
            {
                case Car car:
                    Console.Write("Seats In Vehicle: ");
                    car.SeatsInVehicle = int.Parse(Console.ReadLine()!);
                    break;

                case Truck truck:
                    Console.Write("Cargo Capacity (kg): ");
                    truck.CargoCapacity = double.Parse(Console.ReadLine()!);
                    break;

                case Motorcycle motorcycle:
                    Console.Write("Has Side Seat (yes/no): ");
                    motorcycle.HasSideSeat = Console.ReadLine()!.ToLower() == "yes";
                    break;

                case ElectricScooter scooter:
                    Console.Write("Battery Range (km): ");
                    scooter.BatteryRange = int.Parse(Console.ReadLine()!);

                    Console.Write("Battery Percentage (1-100%): ");
                    scooter.BatteryPercentage = int.Parse(Console.ReadLine()!);

                    if (scooter.BatteryPercentage < 15)
                        Console.WriteLine($"⚠️ {new BatteryChargeFailureError().ErrorMessage()}");
                    break;
            }
        }
        catch (FormatException)
        {
            throw new ArgumentException("Invalid input format for vehicle-specific property.");
        }
    }

    public void ListVehicles()
    {
        if (!vehicles.Any())
        {
            Console.WriteLine("No vehicles registered.");
            return;
        }

        Console.WriteLine("\n=== Registered Vehicles ===");
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