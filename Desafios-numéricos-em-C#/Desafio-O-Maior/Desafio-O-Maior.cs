using System;

class MinhaClasse
{
   static void Main()
    {
        string[] vet = Console.ReadLine().Split(' ');
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);

        int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

        int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

        Console.WriteLine($"{MAIOR} eh o maior");
    }

}