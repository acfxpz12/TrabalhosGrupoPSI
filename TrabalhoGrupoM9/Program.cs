using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrupoM9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 números:");

            // Loop para receber os 10 números do usuário
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Insira um número valido:");
                    Console.Write($"Número {i + 1}: ");
                }
            }

            // Encontrar o maior número
            int maior = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            // Exibir o maior número
            Console.WriteLine($"\nO maior número digitado foi: {maior}");
            Console.WriteLine("Maior valor {0} e índice {1}.", maximo, indice);
            Console.WriteLine("****************");

            Console.Write("a fechar o programa...");
            Console.ReadLine();
        }
        
    }
}
