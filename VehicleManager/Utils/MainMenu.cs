using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManager.Vehicles;

namespace VehicleManager.Utils
{
    public class MainMenu
    {
        private readonly VehicleHandler handler;

        public MainMenu(VehicleHandler handler)
        {
            Console.OutputEncoding = Encoding.UTF8;
            this.handler = handler;
        }   
        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n===== Vehicle System =====");
                Console.WriteLine("1. Add New Vehicle");
                Console.WriteLine("2. Update Vehicle");
                Console.WriteLine("3. List All Vehicles");
                Console.WriteLine("4. Display System Errors");
                Console.WriteLine("0. Exit");
                Console.Write("Select option: ");
                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1": handler.AddVehicle(); break;
                        case "2": handler.UpdateVehicle(); break;
                        case "3": handler.ListVehicles(); break;
                        case "4": break;
                        case "0": isRunning = false; break;
                        default: Console.WriteLine("Invalid option"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Operation failed: {ex.Message}");
                }
            }
        }
    }
}
