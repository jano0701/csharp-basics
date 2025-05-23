using System;
using System.IO;

class TryCatchFinally
{
  static void Main()
  {
    string dateiname = "beispiel.txt";

    try
    {
      // Versuch, die Datei zu lesen (existiert vielleicht nicht)
      string inhalt = File.ReadAllText(dateiname);
      Console.WriteLine("Dateiinhalte:");
      Console.WriteLine(inhalt);
    }
    catch (FileNotFoundException)
    {
      // Wird ausgeführt, wenn die Datei nicht gefunden wurde
      Console.WriteLine("Fehler: Datei wurde nicht gefunden.");
    }
    finally
    {
      // Wird **immer** ausgeführt – egal ob mit oder ohne Fehler
      Console.WriteLine("Programm beendet.");
    }
  }
}
