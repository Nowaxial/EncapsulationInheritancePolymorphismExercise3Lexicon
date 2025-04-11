using System.Text;
using VehicleManager.Vehicles;
using VehicleManager.Utils;

namespace VehicleManager;

internal class Program
{
    static void Main(string[] args)
    {
        // Frågor och svar:
        // 1. Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
        //    - Der kommer att bli en konlikt då Car och Motorcycle är olika klasser. Du kan inte lägga till en Car i en lista av Motorcycle eller vice versa.
        //
        // 2. Vilken typ bör en lista vara för att rymma alla fordonstyper?
        //    - List<Vehicle> eftersom alla fordon ärver från Vehicle som är basklassen.
        //
        // 3. Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
        //    - Nej, eftersom Clean() är en metod i ICleanable och inte i Vehicle. Du måste först kontrollera om objektet är av typen ICleanable:
        //    - if (vehicle is ICleanable cleanable) { cleanable.Clean(); }
        //
        // 4. Vad är fördelarna med att använda ett interface här istället för arv?
        //    - En klass kan implementera flera interfaces
        //    - Möjlighet att lägga till funktionalitet till befintliga klasser
        //    - Bättre separation av ansvar (interface förklarar vad, en class förklarar hur)
        //    - Flexibilitet och återanvändbarhet


        // Skapar en instans av VehicleHandler som hanterar fordon
        var handler = new VehicleHandler();

        // Skapar en instans av MainMenu som hanterar användargränssnittet
        var menu = new MainMenu(handler);

        // Kör huvudmenyn
        menu.Run();
    }
}