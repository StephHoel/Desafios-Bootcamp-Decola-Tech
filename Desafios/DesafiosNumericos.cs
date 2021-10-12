using System;
using System.Globalization;

namespace Desafios
{
   public class DesafiosNumericos
   {
      public static void Maior()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em determinar qual é o maior valor dentre");
         Console.WriteLine("os valores informados");
         Console.WriteLine();

         Console.Write("Informe três números inteiros com um espaço entre eles (Ex: 1 2 3): ");
         string[] vet = Console.ReadLine().Split(' ');
         Console.WriteLine();

         int a = int.Parse(vet[0]);
         int b = int.Parse(vet[1]);
         int c = int.Parse(vet[2]);

         int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

         int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

         Console.WriteLine($"{MAIOR} é o maior");

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
      public static void Coordenadas()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber dois valores para determinar onde nos");
         Console.WriteLine("eixos X e Y a coordenada está localizada");
         Console.WriteLine();

         Console.Write("Informe as coordenadas com um espaço entre os valores (Ex: 10 12,5): ");
         string[] valores = Console.ReadLine().Split(' ');
         Console.WriteLine();

         double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
         double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

         if (x == y && x == 0)
         {
            Console.WriteLine("Origem");
         }
         else if (x == 0)
         {
            Console.WriteLine("Eixo Y");
         }
         else if (y == 0)
         {
            Console.WriteLine("Eixo X");
         }
         else if (x > 0 && y > 0)
         {
            Console.WriteLine("Q1");
         }
         else if (x < 0.0 && y > 0.0)
         {
            Console.WriteLine("Q2");
         }
         else if (x < 0.0 && y < 0.0)
         {
            Console.WriteLine("Q3");
         }
         else
         {
            Console.WriteLine("Q4");
         }

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
      public static void SequenciaLogica()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber dois valores e exibir os números");
         Console.WriteLine("de 1 até segundo número informado, sendo o primeiro a quantidade de");
         Console.WriteLine("dígitos por linha");
         Console.WriteLine();

         Console.Write("Informe dois números, sendo o primeiro a quantidade de dígitos por linha e o segundo o limite da exibição: ");
         string[] vet = Console.ReadLine().Split(' ');
         Console.WriteLine();

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

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
      public static void Combustivel()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber 'pedidos' dos combustíveis e depois");
         Console.WriteLine("informar quantos pedidos foram feitos");
         Console.WriteLine();

         int alcool = 0;
         int gasolina = 0;
         int diesel = 0;
         string i;

         do
         {
            Console.Write("Informe 1 para Álcool, 2 para Gasolina ou 3 para Diesel: ");
            i = Console.ReadLine();
            Console.WriteLine();

            switch (i)
            {
               case "1":
                  alcool++;
                  continue;
               case "2":
                  gasolina++;
                  continue;
               case "3":
                  diesel++;
                  continue;
               case "4":
                  break;
               default:
                  Console.Write("Opção inválida. Pressione ENTER para continuar...");
                  Console.ReadLine();
                  continue;
            }
         } while (i != "4");

         Console.WriteLine();
         Console.WriteLine("MUITO OBRIGADO");
         Console.WriteLine("Alcool: " + alcool);
         Console.WriteLine("Gasolina: " + gasolina);
         Console.WriteLine("Diesel: " + diesel);

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
      public static void Triangulo()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber 3 valores e determinar se os valores");
         Console.WriteLine("não formam um triângulo, se formam um triângulo retângulo,");
         Console.WriteLine("um triângulo obtusângulo, um triângulo acutângulo, um triângulo equilátero");
         Console.WriteLine("e/ou um triângulo isósceles");
         Console.WriteLine();

         Console.Write("Informe três valores com um espaço entre eles (Ex: 2 4 9): ");
         string[] s = Console.ReadLine().Split(' ');
         Console.WriteLine();

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

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
      public static void ValidacaoNota()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber notas individualmente");
         Console.WriteLine("e quando receber duas notas válidas, informar a média");
         Console.WriteLine("");
         Console.WriteLine();

         string input;
         decimal soma = 0;
         decimal i = 0;

         do
         {
            Console.Write("Informe uma nota válida: ");
            input = Console.ReadLine();
            Console.WriteLine();

            if (decimal.TryParse(input, out decimal entrada) && entrada >= 0 && entrada <= 10)
            {
               soma += entrada;
               i++;
            }
            else
            {
                Console.WriteLine("nota invalida");
                Console.WriteLine();
            }
         }
         while (i < 2);

         Console.WriteLine("media = " + soma / 2);

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }

   }
}