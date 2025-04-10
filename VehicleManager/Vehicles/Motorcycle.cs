using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Vehicles;

public class Motorcycle : Vehicle
{
    public bool HasSideSeat { get; set; }

    public override string StartEngine()
    {
        return "🏍️Motor cycle engine revved loudly";
    }

    public override string Stats()
    {
        return $"{base.Stats()}| Has Sideseat: {HasSideSeat}"
        ;
    }
}
