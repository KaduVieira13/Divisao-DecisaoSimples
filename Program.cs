using System;

namespace Divisao_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool denominadorValido;
            int novoDenominador;

            Console.WriteLine("--- Divisão ---\n");

            Console.Write("Digite um numerador: ");
            int numeradorDigitado = Convert.ToInt32(Console.ReadLine());

             Console.Write("Digite um denominador: ");
            string denominadorDigitado = Console.ReadLine();

            denominadorValido = Int32.TryParse(denominadorDigitado,out novoDenominador);

            if (novoDenominador == 0)
            {
                Console.WriteLine("Não é possível dividir por zero, tente novamente!");
            }
            else
            {
            int resultadoDivisao = numeradorDigitado / novoDenominador;
            Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}.");
            }



         
        

            
            

            
        }
    }
}
