using System.Text;
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
            Console.WriteLine("3. Display System Errors");
            Console.WriteLine("0. Exit");
            Console.Write("Select option: ");

            switch (Console.ReadLine())
            {
                case "1": handler.AddVehicle(); break;
                case "2": handler.ListVehicles(); break;
                case "3": break;
                case "0": isRunning = false; break;
                default: Console.WriteLine("Invalid option"); break;
            }
        }
    }
}