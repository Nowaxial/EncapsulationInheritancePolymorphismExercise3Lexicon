using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Vehicles;

public class VehicleHandler
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    public void AddVehicle(Vehicle vehicle) 
    {  
        vehicles.Add(vehicle); 
    }
}
