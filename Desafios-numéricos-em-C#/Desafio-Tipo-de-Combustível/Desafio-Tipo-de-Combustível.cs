using System;

class MinhaClasse
{
   static void Main()
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int i;

        do
        {

            i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                alcool++;
                continue;
                case 2:
                gasolina++;
                continue;
                case 3:
                diesel++;
                continue;
                case 4:
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);
                break;
                default:
                continue;
            }
        }

        while (i != 4);
    }

}