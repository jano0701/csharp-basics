using System;

class TryCatchBasic
{
  static void Main()
  {
    Console.Write("Gib eine ganze Zahl ein: ");
    string eingabe = Console.ReadLine();

    try
    {
      // Versuch, den Text in eine Zahl umzuwandeln
      int zahl = Convert.ToInt32(eingabe);
      Console.WriteLine($"Du hast die Zahl {zahl} eingegeben.");
    }
    catch (FormatException)
    {
      // Dieser Block wird ausgeführt, wenn die Eingabe keine Zahl ist
      Console.WriteLine("Fehler: Ungültige Eingabe – bitte gib nur Zahlen ein.");
    }
  }
}
