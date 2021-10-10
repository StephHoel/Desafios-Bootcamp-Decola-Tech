using System;

class MinhaClasse
{
   static void Main()
    {
        var timeInSeconds = int.Parse(Console.ReadLine());

        var hours = timeInSeconds / (60 * 60);
        timeInSeconds %= (60 * 60);
        var minutes = timeInSeconds / 60;
        var seconds = timeInSeconds % 60;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }

}