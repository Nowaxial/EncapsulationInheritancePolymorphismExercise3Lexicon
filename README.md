# Övning 3 : Fordonshanteringssystem (Inkapsling, Arv & Polymorfism i C#)

**Del 1: Inkapsling**

1. Skapa en klass Vehicle med följande privata fält:

```
private string brand;
private string model;
private int year;
private double weight;
```

2. Skapa publika **properties** med validering:

```
o Brand och Model måste vara mellan 2 och 20 tecken.
o Year får inte vara tidigare än 1886 (bilens uppfinning) eller senare än nuvarande
år.
o Weight måste vara ett positivt värde.
```
3. Om validering inte uppfylls: kasta ArgumentException med relevant felmeddelande.
4. Skapa en klass VehicleHandler med metoder för att:

```
o Skapa ett nytt fordon.
o Ändra värden (t.ex. sätt vikt, modell etc.)
```
```
o Lista fordon.
```
5. Hantera eventuella undantag med try-catch i Program.cs.

**Del 2: Polymorfism**

1. Skapa en **abstrakt klass** SystemError med en abstrakt metod ErrorMessage().
2. Skapa minst tre underklasser:

```
o EngineFailureError: returnerar t.ex. "Motorfel: Kontrollera motorstatus!"
o BrakeFailureError: returnerar t.ex. "Bromsfel: Fordonet är osäkert att köra!"
```
```
o TransmissionError: returnerar t.ex. "Växellådsproblem: Reparation krävs!"
```
3. Lägg alla error-objekt i en lista och skriv ut samtliga felmeddelanden via en foreach.


**Del 3: Arv**

1. Skapa en **abstrakt klass** Vehicle (om du inte redan gjort det) med metoden StartEngine()
    och Stats()
2. Skapa subklasser:

```
o Car
o Truck
```
```
o Motorcycle
o ElectricScooter
```
Ge varje fordonstyp minst en unik egenskap (t.ex. BatteryRange, CargoCapacity, HasSidecar).

3. Override StartEngine() så att varje fordon "startar" på sitt eget sätt (textbaserat).

**Del 4: Mer polymorfism**

1. Skapa en lista av typen List<Vehicle> och fyll med olika fordon.
2. Loopa igenom listan:

```
o Skriv ut Stats() (skriv ut de olika attributen de olika fordonen har)
o Anropa StartEngine()
```
3. Skapa ett interface ICleanable med metoden Clean(). Låt t.ex. Truck och Car
    implementera det.
4. I loopen, kontrollera om ett fordon är ICleanable, och anropa då Clean().

**Frågor (besvaras som kommentarer i koden):**

- F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
- F: Vilken typ bör en lista vara för att rymma alla fordonstyper?
- F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
- F: Vad är fördelarna med att använda ett interface här istället för arv?


