using VehicleManager.Errors;
using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles;

public class VehicleHandler
{
    private readonly List<Vehicle> vehicles = new List<Vehicle>();

    //Lägger till ett fordon
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

    //Väljer fordonstyp
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

            try //Try-catch block som fångar ogiltiga inmatningar
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

    //Sätter gemensamma fordonsegenskaper
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
    //Sätter fordonsspecifika egenskaper
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
            throw new ArgumentException("Invalid input format");
        }
    }

    //Visar alla registrerade fordon
    public void ListVehicles()
    {
        if (!vehicles.Any())
        {
            Console.WriteLine("No vehicles registered.");
            return;
        }

        Console.WriteLine("\n=== Registered Vehicles ===");


        // Visa fordon med detaljerad information på en rad och lägger till en siffror för varje fordon
        for (int i = 0; i < vehicles.Count; i++)
        {
            var vehicle = vehicles[i];
            Console.WriteLine($"\n{i + 1}. {vehicle.Stats()}");
            Console.WriteLine($"🔧 {vehicle.StartEngine()}");

            // Om fordonet implementerar ICleanable, anropa Clean() metoden
            if (vehicle is ICleanable cleanable)
            {
                Console.Write("🧼 Cleaning: ");
                cleanable.Clean();
            }
        }
    }
    //Uppdaterar ett fordon
    public void UpdateVehicle()
    {
        if (!vehicles.Any())
        {
            Console.WriteLine("No vehicles registered.");
            return;
        }
        Console.WriteLine("\n=== Update Vehicle ===");

        // Visa fordon med detaljerad information på en rad
        for (int i = 0; i < vehicles.Count; i++)
        {
            Vehicle vehicle = vehicles[i];

            string vehicleInfo = $"{i + 1}.  Type: {vehicle.GetType().Name} | Brand: {vehicle.Brand} | Model: {vehicle.Model} | Year: {vehicle.Year}";

            // Lägg till fordonsspecifika egenskaper på samma rad
            if (vehicle is Car car)
            {
                vehicleInfo += $" | Seats: {car.SeatsInVehicle}";
            }
            else if (vehicle is Motorcycle mc)
            {
                vehicleInfo += $" | Has Side Seat: {mc.HasSideSeat}";
            }
            else if (vehicle is Truck truck)
            {
                vehicleInfo += $" | CargoCapacity: {truck.CargoCapacity}kg";
            }
            else if (vehicle is ElectricScooter scooter)
            {
                vehicleInfo += $" | Battery Range: {scooter.BatteryRange}km | Battery Percentage: {scooter.BatteryPercentage}%";
            }

            Console.WriteLine(vehicleInfo);
        }

        // Användarens val av fordon att uppdatera
        Console.Write("Enter the number of the vehicle you want to update: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > vehicles.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Konvertera från användarvänligt nummer (1-baserat) till index (0-baserat)
        int index = choice - 1;
        Vehicle selectedVehicle = vehicles[index];

        SetCommonVehicleProperties(selectedVehicle);
        SetVehicleSpecificProperties(selectedVehicle);
        Console.WriteLine("Vehicle updated successfully!");
    }

    //Visar systemfel
    public static void DisplaySystemErrors()
    {
        int counter = 1;
        var errors = new List<SystemError>
{
        new EngineFailureError(),
        new BrakeFailureError(),
        new TransmissionError(),
        new BatteryChargeFailureError(),
        new FuelFailureError()
};

        foreach (var error in errors)
        {
            
            // Användning av polymorfism för att anropa ErrorMessage() metoden
            Console.WriteLine($"{counter++}.⚠️ {error.ErrorMessage()}");
        }
    }
}