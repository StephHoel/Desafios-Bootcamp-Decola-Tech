using System;

class MinhaClasse
{
   static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);

        double a2 = Math.Max(a, Math.Max(b, c));
        double c2 = Math.Min(a, Math.Min(b, c));
        double b2 = a + b + c - a2 - c2;

        if (a2 >= b2 + c2)
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (Math.Pow(a2, 2) == Math.Pow(b2, 2) + Math.Pow(c2, 2))
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (Math.Pow(a2, 2) > Math.Pow(b2, 2) + Math.Pow(c2, 2))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (Math.Pow(a2, 2) < Math.Pow(b2, 2) + Math.Pow(c2, 2))
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (a2 == b2 && b2 == c2)
            Console.WriteLine("TRIANGULO EQUILATERO");
        if (a2 == b2 && b2 != c2 || b2 == c2 && c2 != a2)
            Console.WriteLine("TRIANGULO ISOSCELES");

        Console.ReadLine();
    }

}