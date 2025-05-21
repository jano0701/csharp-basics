using System;

class IfElseIfElse
{
  static void Main()
  {
    int temperatur = 15;

    // Prüft mehrere Bedingungen nacheinander
    if (temperatur > 30)
    {
      Console.WriteLine("Es ist heiß.");
    }
    else if (temperatur > 20)
    {
      Console.WriteLine("Es ist warm.");
    }
    else
    {
      Console.WriteLine("Es ist kühl.");
    }

    Console.WriteLine("Temperaturprüfung abgeschlossen.");
  }
}
