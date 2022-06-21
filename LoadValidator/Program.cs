using System;
using System.Collections.Generic;

namespace LoadValidator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LOAD VALIDATOR\n\n");

            var stack = new List<int>();
            var IsStackFinished = false;

            while (!IsStackFinished)
            {
                try
                {
                    Console.Write("Digite o peso da posição número {0}, ou digite '0' para finalizar a pilha: ", stack.Count + 1);
                    
                    int input = int.Parse(Console.ReadLine());
                    if (input == 0) IsStackFinished = true;
                    else stack.Add(input);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Deve ser digitado um valor numérico!\n");
                    Console.WriteLine("Pressione qualquer botão para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.Clear();
            Console.WriteLine("Quantidades de passos para colocar a carga de no formato correto: {0}", LoadValidator.StepsNeeded(stack));
            Console.ReadKey();
        }
    }
}
