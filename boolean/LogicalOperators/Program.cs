using System;

class LogicalOperators
{
  static void Main()
  {
    bool istWarm = true;
    bool istTrocken = false;

    // UND-Operator (&&): beide Bedingungen müssen true sein
    bool gutesWetter = istWarm && istTrocken;
    Console.WriteLine("Ist das Wetter gut (warm UND trocken)? " + gutesWetter);

    // ODER-Operator (||): eine der Bedingungen reicht
    bool gehtSpazieren = istWarm || istTrocken;
    Console.WriteLine("Gehe ich spazieren (wenn warm ODER trocken)? " + gehtSpazieren);

    // NICHT-Operator (!): kehrt den Wert um
    bool bleibeDrinnen = !gehtSpazieren;
    Console.WriteLine("Bleibe ich drinnen? " + bleibeDrinnen);
  }
}
