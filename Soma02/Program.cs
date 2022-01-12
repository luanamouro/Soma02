using System;

namespace Soma02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma = 0;
            Console.WriteLine("Soma Números\n\n");
            Console.WriteLine("Digite o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
            {
                for (int i = n1; i < n2; i++)
                {
                    soma = soma + i;
                }
                Console.WriteLine("Somatório: {0}", soma.ToString());


            }

            else
            {
                Console.WriteLine(" O primeiro número deve ser menor que o segundo.");
            }

        }
    }
}
