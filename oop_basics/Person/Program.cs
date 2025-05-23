using System;

namespace OOPBasics
{
  // Diese Klasse beschreibt eine Person mit Name und Alter
  public class Person
  {
    // Eigenschaften (Felder mit get/set)
    public string Name { get; set; }
    public int Alter { get; set; }

    // Konstruktor: wird beim Erzeugen des Objekts automatisch aufgerufen
    public Person(string name, int alter)
    {
      Name = name;
      Alter = alter;
    }

    // Methode: führt eine Aktion mit den Objektdaten aus
    public void Begruessen()
    {
      Console.WriteLine($"Hallo, mein Name ist {Name} und ich bin {Alter} Jahre alt.");
    }
  }
}
