using System;

class FactorialFunction
{
  static int Fakultaet(int n)
  {
    if (n <= 1)
      return 1;
    return n * Fakultaet(n - 1);
  }

  static void Main()
  {
    Console.Write("Gib eine Zahl ein: ");
    int zahl = int.Parse(Console.ReadLine());
    Console.WriteLine($"Fakultät von {zahl} ist {Fakultaet(zahl)}");
  }
}
