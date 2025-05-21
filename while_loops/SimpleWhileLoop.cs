using System;

class SimpleWhileLoop
{
  static void Main()
  {
    int count = 1;

    // Solange count kleiner oder gleich 5 ist, wiederhole die Schleife
    while (count <= 5)
    {
      Console.WriteLine("Zähler: " + count);
      count++; // Zähler erhöhen
    }

    Console.WriteLine("Fertig mit der while-Schleife.");
  }
}
