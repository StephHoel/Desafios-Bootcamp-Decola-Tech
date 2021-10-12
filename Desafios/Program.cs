using System;
using System.Globalization;
using System.Xml;

namespace Desafios
{
   class Program
   {
      static void Main()
      {
         Console.Clear();
         Console.WriteLine("Menu dos Desafios!");
         Console.WriteLine("Cada opção te levará para um desafio diferente");
         Console.WriteLine("Cada um desses desafios foi realizado no bootcamp Decola Tech" +
            Environment.NewLine + "pela plataforma da Digital Innovation One e adaptado para" +
            Environment.NewLine + "funcionar nesta aplicação console");
         Console.WriteLine();

         string op;

         do
         {
            Console.WriteLine("1 - Desafio: Soma");
            Console.WriteLine("2 - Desafio: DDD");
            Console.WriteLine("3 - Desafio: Múltiplos");
            Console.WriteLine("4 - Desafio: Números Ímpares");
            Console.WriteLine("5 - Desafio: Conversão de Tempo");
            Console.WriteLine("6 - Desafio: Tempo do Dobby");
            Console.WriteLine("7 - Desafio: O Maior");
            Console.WriteLine("8 - Desafio: Coordenadas de um Ponto");
            Console.WriteLine("9 - Desafio: Sequência Lógica 2");
            Console.WriteLine("10 - Desafio: Tipo de Combustível");
            Console.WriteLine("11 - Desafio: Tipos de Triângulos");
            Console.WriteLine("12 - Desafio: Validação de Nota");
            Console.WriteLine("0 - Sair");

            Console.Write("Informe o desafio que deseja acessar: ");
            op = Console.ReadLine();

            switch (op)
            {
               case "1":
                  Console.Clear();
                  DesafiosMatematicos.Soma();
                  Console.Clear();
                  continue;
               case "2":
                  Console.Clear();
                  DesafiosMatematicos.DDD();
                  Console.Clear();
                  continue;
               case "3":
                  Console.Clear();
                  DesafiosIntroducao.Multiplos();
                  Console.Clear();
                  continue;
               case "4":
                  Console.Clear();
                  DesafiosIntroducao.NumerosImpares();
                  Console.Clear();
                  continue;
               case "5":
                  Console.Clear();
                  DesafiosIntroducao.ConversaoTempo();
                  Console.Clear();
                  continue;
               case "6":
                  Console.Clear();
                  DesafiosIntroducao.TempoDobby();
                  Console.Clear();
                  continue;
               case "7":
                  Console.Clear();
                  DesafiosNumericos.Maior();
                  Console.Clear();
                  continue;
               case "8":
                  Console.Clear();
                  DesafiosNumericos.Coordenadas();
                  Console.Clear();
                  continue;
               case "9":
                  Console.Clear();
                  DesafiosNumericos.SequenciaLogica();
                  Console.Clear();
                  continue;
               case "10":
                  Console.Clear();
                  DesafiosNumericos.Combustivel();
                  Console.Clear();
                  continue;
               case "11":
                  Console.Clear();
                  DesafiosNumericos.Triangulo();
                  Console.Clear();
                  continue;
               case "12":
                  Console.Clear();
                  DesafiosNumericos.ValidacaoNota();
                  Console.Clear();
                  continue;

               case "0":
                  break;

               default:
                  Console.WriteLine();
                  Console.WriteLine("Opção inválida. Pressione ENTER para continuar...");
                  Console.ReadLine();
                  Console.Clear();
                  continue;
            }

         } while (op != "0");

         Console.WriteLine("Obrigada por testar os desafios que concluí!");
         Console.WriteLine("Pressione ENTER para continuar...");
         Console.ReadLine();
         Console.Clear();

      }

   }
}