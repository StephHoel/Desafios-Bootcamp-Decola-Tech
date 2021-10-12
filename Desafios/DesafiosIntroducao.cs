using System;

namespace Desafios
{
   public class DesafiosIntroducao
   {
        public static void Multiplos()
        {
            Console.WriteLine();
            Console.WriteLine("Este código consiste em receber dois valores na mesma linha");
            Console.WriteLine("e informar se são múltiplos ou não");
            Console.WriteLine();

            Console.Write("Informe 2 valores com 1 espaço entre eles (Ex: 2 4): ");
            string[] valores = Console.ReadLine().Split(' ');

            Console.WriteLine();

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        public static void NumerosImpares()
        {
            Console.WriteLine();
            Console.WriteLine("Este código consiste em receber um número qualquer e informar");
            Console.WriteLine("todos os números ímpares de 0 até o número informado");
            Console.WriteLine();

            int n;
            Console.WriteLine("Informe 1 número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                if ((i % 2) != 0)
                {
                Console.WriteLine(i);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        public static void ConversaoTempo()
      {
         Console.WriteLine();
         Console.WriteLine("Este código consiste em receber um valor inteiro de segundos e");
         Console.WriteLine("convertê-lo em horas, minutos e/ou segundos");
         Console.WriteLine();

         Console.Write("Informe um valor inteiro de segundos: ");
         var timeInSeconds = int.Parse(Console.ReadLine());

         Console.WriteLine();

         var hours = timeInSeconds / (60 * 60);
         timeInSeconds %= (60 * 60);
         var minutes = timeInSeconds / 60;
         var seconds = timeInSeconds % 60;

         Console.WriteLine($"{hours}:{minutes}:{seconds}");

         Console.WriteLine();
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
      }
        public static void TempoDobby()
        {
            Console.WriteLine();
            Console.WriteLine("Este código consiste em receber três valores divididos em duas");
            Console.WriteLine("linhas para determinar se o elfo fará a tarefa naquele dia ou deixará");
            Console.WriteLine("para o dia seguinte");
            Console.WriteLine();

            Console.Write("Informe quantos minutos faltam para o final do expediente (inteiro): ");
            string[] line1 = Console.ReadLine().Split(" ");

            Console.Write("Informe quantos minutos cada um dos 2 brinquedos levarão para serem concluidos (Ex: 10 5): ");
            string[] line2 = Console.ReadLine().Split(" ");

            Console.WriteLine();

            int finalExpediente = int.Parse(line1[0]);

            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            //continue a solucao
            int totalNecessario = presente1 + presente2;

            if (totalNecessario > finalExpediente)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
   }
}