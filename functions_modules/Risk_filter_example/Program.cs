using System;
using System.Collections.Generic;
using System.Linq;

class Risk
{
  public string Name;
  public int Level;
  public string Status;

  public Risk(string name, int level, string status)
  {
    Name = name;
    Level = level;
    Status = status;
  }
}

class RiskFilterExample
{
  static List<Risk> FilterKritischeRisiken(List<Risk> liste)
  {
    return liste.Where(r => r.Level >= 8).ToList();
  }

  static void Main()
  {
    var risiken = new List<Risk>
        {
            new Risk("Systemausfall", 9, "Offen"),
            new Risk("Zahlungsverzug", 5, "Offen"),
            new Risk("Datenleck", 8, "Bearbeitung")
        };

    var kritisch = FilterKritischeRisiken(risiken);

    Console.WriteLine("Kritische Risiken:");
    foreach (var r in kritisch)
    {
      Console.WriteLine($"- {r.Name} (Level {r.Level})");
    }
  }
}
