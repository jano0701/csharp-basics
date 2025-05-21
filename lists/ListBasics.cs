using System;
using System.Collections.Generic;

class ListBasics
{
  static void Main()
  {
    // Erstelle eine Liste mit Strings (z. B. Namen)
    List<string> namen = new List<string>();

    // Elemente zur Liste hinzufügen
    namen.Add("Anna");
    namen.Add("Ben");
    namen.Add("Chris");

    // Zugriff auf ein Element über den Index (0 = erstes Element)
    Console.WriteLine("Erster Name: " + namen[0]);

    // Anzahl der Elemente in der Liste
    Console.WriteLine("Anzahl der Namen: " + namen.Count);

    // Alle Elemente mit einer Schleife durchlaufen
    Console.WriteLine("\nAlle Namen:");
    foreach (string name in namen)
    {
      Console.WriteLine("- " + name);
    }
  }
}
