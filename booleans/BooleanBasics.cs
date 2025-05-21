using System;

class BooleanBasics
{
  static void Main()
  {
    // Ein bool-Wert ist entweder true (wahr) oder false (falsch)
    bool istSonnig = true;
    bool istRegnerisch = false;

    Console.WriteLine("Ist es sonnig? " + istSonnig);
    Console.WriteLine("Ist es regnerisch? " + istRegnerisch);

    // Booleans können auch das Ergebnis eines Vergleichs sein
    int alter = 18;
    bool istVolljaehrig = alter >= 18;

    Console.WriteLine("Ist die Person volljährig? " + istVolljaehrig);
  }
}
