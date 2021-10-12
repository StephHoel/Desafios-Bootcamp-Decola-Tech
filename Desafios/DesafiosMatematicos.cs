using System;

namespace Desafios
{
    public class DesafiosMatematicos
    {
        public static void Soma()
        {
            Console.WriteLine();
            Console.WriteLine("Este código consiste em receber dois valores e realizar a soma dos mesmos");
            Console.WriteLine();

            //Declarando Variáveis e Recebendo os valores
            Console.Write("Digite o primeiro valor: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int B = Convert.ToInt32(Console.ReadLine());

            //Fazendo a lógica de soma
            int SOMA = A + B;

            //Imprimindo a resposta da soma
            Console.WriteLine();
            Console.WriteLine("SOMA = {0}", SOMA);

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
      }

        public static void DDD()
        {
            Console.WriteLine();
            Console.WriteLine("Este código consiste em receber um DDD e informar de qual cidade");
            Console.WriteLine("é ou se não está registrado");
            Console.WriteLine();

            Console.Write("Digite o DDD: ");
            int ddd = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                Console.WriteLine("Brasilia");
                break;
                case 71:
                Console.WriteLine("Salvador");
                break;
                case 11:
                Console.WriteLine("Sao Paulo");
                break;
                case 21:
                Console.WriteLine("Rio de Janeiro");
                break;
                case 32:
                Console.WriteLine("Juiz de Fora");
                break;
                case 19:
                Console.WriteLine("Campinas");
                break;
                case 27:
                Console.WriteLine("Vitoria");
                break;
                case 31:
                Console.WriteLine("Belo Horizonte");
                break;
                default:
                Console.WriteLine("DDD nao cadastrado");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}