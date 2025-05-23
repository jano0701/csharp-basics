using System;

class LoopThroughArray
{
  static void Main()
  {
    // Ein Array mit Tiernamen
    string[] tiere = { "Hund", "Katze", "Vogel" };

    // Schleife über das Array
    for (int i = 0; i < tiere.Length; i++)
    {
      Console.WriteLine($"Index {i}: {tiere[i]}");
    }
  }
}
