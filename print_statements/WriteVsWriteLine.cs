using System;

class WriteVsWriteLine
{
  static void Main()
  {
    // Write gibt Text ohne Zeilenumbruch aus
    Console.Write("A");
    Console.Write("B");
    Console.Write("C");

    // Ausgabe: ABC

    Console.WriteLine(); // Nur ein Zeilenumbruch

    // WriteLine fügt automatisch einen Zeilenumbruch an
    Console.WriteLine("X");
    Console.WriteLine("Y");
    Console.WriteLine("Z");

    // Ausgabe:
    // X
    // Y
    // Z
  }
}
