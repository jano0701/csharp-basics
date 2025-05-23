using System;

class FunctionsWithReturn
{
  static int Verdopple(int x)
  {
    return x * 2;
  }

  static void Main()
  {
    int eingabe = 5;
    int ergebnis = Verdopple(eingabe);
    Console.WriteLine($"{eingabe} verdoppelt ergibt {ergebnis}");
  }
}