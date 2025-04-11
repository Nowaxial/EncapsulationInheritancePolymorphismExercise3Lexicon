using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManager.Vehicles;

namespace VehicleManager.Utils
{
    //Huvudmenyn för programmet
    public class MainMenu
    {

        //Skapar en instans av VehicleHandler
        private readonly VehicleHandler handler;


        //Konstruktorn för MainMenu
        public MainMenu(VehicleHandler handler)
        {
            //Sätter konsolens teckenkodning till UTF-8 och tilldelar handler med this.handler som referens
            Console.OutputEncoding = Encoding.UTF8;
            this.handler = handler;
        }

        //Kör programmet
        public void Run()
        {
            bool isRunning = true;

            //Huvudmenyn som körs så länge isRunning är true
            while (isRunning)
            {
                Console.WriteLine("\n===== Vehicle System =====");
                Console.WriteLine("1. Add New Vehicle");
                Console.WriteLine("2. Update Vehicle");
                Console.WriteLine("3. List All Vehicles");
                Console.WriteLine("4. Display System Errors");
                Console.WriteLine("0. Exit");
                Console.Write("Select option: ");

                //Try-catch för att fånga inmatningsfel och ogiltiga val, även case för att hantera olika alternativ som användaren kan välja
                try
                {
                    switch (Console.ReadLine())
                    {
                        case "1": handler.AddVehicle(); break;
                        case "2": handler.UpdateVehicle(); break;
                        case "3": handler.ListVehicles(); break;
                        case "4": VehicleHandler.DisplaySystemErrors(); break;
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
