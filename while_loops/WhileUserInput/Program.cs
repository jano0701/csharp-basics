using System;

class WhileUserInput
{
  static void Main()
  {
    string eingabe = "";

    while (eingabe.ToLower() != "exit")
    {
      Console.Write("Gib etwas ein (oder 'exit' zum Beenden): ");
      eingabe = Console.ReadLine();

      Console.WriteLine("Du hast eingegeben: " + eingabe);
    }

    Console.WriteLine("Programm beendet.");
  }
}
