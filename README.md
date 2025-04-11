# �vning 3 : Fordonshanteringssystem (Inkapsling, Arv & Polymorfism i C#)

**Del 1: Inkapsling**

1. Skapa en klass Vehicle med f�ljande privata f�lt:

```
private string brand;
private string model;
private int year;
private double weight;
```

2. Skapa publika **properties** med validering:

```
o Brand och Model m�ste vara mellan 2 och 20 tecken.
o Year f�r inte vara tidigare �n 1886 (bilens uppfinning) eller senare �n nuvarande
�r.
o Weight m�ste vara ett positivt v�rde.
```
3. Om validering inte uppfylls: kasta ArgumentException med relevant felmeddelande.
4. Skapa en klass VehicleHandler med metoder f�r att:

```
o Skapa ett nytt fordon.
o �ndra v�rden (t.ex. s�tt vikt, modell etc.)
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
o BrakeFailureError: returnerar t.ex. "Bromsfel: Fordonet �r os�kert att k�ra!"
```
```
o TransmissionError: returnerar t.ex. "V�xell�dsproblem: Reparation kr�vs!"
```
3. L�gg alla error-objekt i en lista och skriv ut samtliga felmeddelanden via en foreach.


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

3. Override StartEngine() s� att varje fordon "startar" p� sitt eget s�tt (textbaserat).

**Del 4: Mer polymorfism**

1. Skapa en lista av typen List<Vehicle> och fyll med olika fordon.
2. Loopa igenom listan:

```
o Skriv ut Stats() (skriv ut de olika attributen de olika fordonen har)
o Anropa StartEngine()
```
3. Skapa ett interface ICleanable med metoden Clean(). L�t t.ex. Truck och Car
    implementera det.
4. I loopen, kontrollera om ett fordon �r ICleanable, och anropa d� Clean().

**Fr�gor (besvaras som kommentarer i koden):**

- F: Vad h�nder om du f�rs�ker l�gga till en Car i en lista av Motorcycle?
- F: Vilken typ b�r en lista vara f�r att rymma alla fordonstyper?
- F: Kommer du �t metoden Clean() fr�n en lista med typen List<Vehicle>?
- F: Vad �r f�rdelarna med att anv�nda ett interface h�r ist�llet f�r arv?


