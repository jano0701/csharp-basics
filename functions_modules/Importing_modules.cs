// In C# werden "Module" meist als Namespaces oder Klassen importiert.
// Dieses Beispiel zeigt die Verwendung eines systemeigenen Moduls

using System;
using System.Globalization;

class ImportingModules
{
  static void Main()
  {
    DateTime heute = DateTime.Now;
    Console.WriteLine("Datum (de-DE): " + heute.ToString("D", new CultureInfo("de-DE")));
    Console.WriteLine("Datum (en-US): " + heute.ToString("D", new CultureInfo("en-US")));
  }
}
