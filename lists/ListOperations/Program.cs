using System;
using System.Collections.Generic;

class ListOperations
{
  static void Main()
  {
    // Liste mit Zahlen
    List<int> zahlen = new List<int> { 5, 3, 9, 1, 7 };

    // Liste sortieren (aufsteigend)
    zahlen.Sort();

    Console.WriteLine("Sortierte Liste:");
    foreach (int zahl in zahlen)
    {
      Console.WriteLine(zahl);
    }

    // Ein neues Element an Position 2 einfügen
    zahlen.Insert(2, 6); // nach Index 2 einfügen

    // Ein Element entfernen (nach Wert)
    zahlen.Remove(3);

    // Prüfen, ob ein bestimmter Wert vorhanden ist
    if (zahlen.Contains(9))
    {
      Console.WriteLine("Die Zahl 9 ist in der Liste.");
    }

    // Ausgabe der finalen Liste
    Console.WriteLine("\nAktuelle Liste:");
    foreach (int zahl in zahlen)
    {
      Console.WriteLine(zahl);
    }
  }
}
