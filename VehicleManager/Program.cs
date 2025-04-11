using System.Text;
using VehicleManager.Vehicles;
using VehicleManager.Utils;

namespace VehicleManager;

internal class Program
{
    static void Main(string[] args)
    {
        var handler = new VehicleHandler();
        var menu = new MainMenu(handler);
        menu.Run();
    }
}