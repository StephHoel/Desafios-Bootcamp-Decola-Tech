using System;

class Program
{
    static void Main()
    {
        //Declarando Variáveis e Recebendo os valores
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        //Fazendo a lógica de soma
        int SOMA = A + B;

        //Imprimindo a resposta da soma
        Console.WriteLine("SOMA = {0}", SOMA);
    }
}