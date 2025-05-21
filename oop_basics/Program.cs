using System;

namespace OOPBasics
{
  class Program
  {
    static void Main(string[] args)
    {
      // Wir erstellen zwei Personen-Objekte
      Person person1 = new Person("Anna", 25);
      Person person2 = new Person("Ben", 32);

      // Die Methode Begruessen wird aufgerufen
      person1.Begruessen();
      person2.Begruessen();

      // Ausgabe:
      // Hallo, mein Name ist Anna und ich bin 25 Jahre alt.
      // Hallo, mein Name ist Ben und ich bin 32 Jahre alt.
    }
  }
}
