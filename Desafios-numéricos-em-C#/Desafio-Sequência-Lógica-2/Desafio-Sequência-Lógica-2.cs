using System;

class MinhaClasse
{
   static void Main()
    {
        string[] vet = Console.ReadLine().Split(' ');

        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);

        for (int i = 1, z = 1; i <= b; i++)
        {
            Console.Write(i);
            if (z == a)
            {
                Console.WriteLine();
                z = 1;
            }
            else
            {
                Console.Write(" ");
                z++;
            }
        }
    }

}