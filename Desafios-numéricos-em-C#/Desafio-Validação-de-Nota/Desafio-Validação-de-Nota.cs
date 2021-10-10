using System;

class MinhaClasse
{
   static void Main()
    {
        decimal entrada = 0;
        decimal soma = 0;
        decimal i = 0;

        do
        {
            entrada = Convert.ToDecimal(Console.ReadLine());

            if (entrada >= 0 && entrada <= 10)
            {
                soma += entrada;
                i++;
            }
            else Console.WriteLine("nota invalida");
        }
        while (i < 2);

        Console.WriteLine("media = " + soma / 2);
    }

}