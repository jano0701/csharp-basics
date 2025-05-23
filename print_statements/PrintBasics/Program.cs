using System;

class PrintBasics
{
  static void Main()
  {
    // Gibt eine Zeile mit Zeilenumbruch aus
    Console.WriteLine("Hello, world!");

    // Gibt mehrere Zahlen in neuen Zeilen aus
    Console.WriteLine(123);
    Console.WriteLine(3.14);

    // Du kannst auch mehrere Zeichenketten kombinieren
    string name = "Jano";
    Console.WriteLine("Hallo, " + name + "!");

    // Escape-Zeichen: \n = Zeilenumbruch, \t = Tabulator
    Console.WriteLine("Zeile 1\nZeile 2");
    Console.WriteLine("Name\tLevel");

    // Ausgabe mit Platzhaltern
    Console.WriteLine("Dein Alter ist: {0}", 25);
  }
}
