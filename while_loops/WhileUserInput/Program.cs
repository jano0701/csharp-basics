using System;

class WhileUserInput
{
  static void Main()
  {
    string eingabe = "";

    // Wiederhole, bis der Benutzer "exit" eingibt
    while (eingabe != "exit")
    {
      Console.Write("Gib etwas ein (oder 'exit' zum Beenden): ");
      eingabe = Console.ReadLine(); // Eingabe lesen

      Console.WriteLine("Du hast eingegeben: " + eingabe);
    }

    Console.WriteLine("Programm beendet.");
  }
}
