using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinharNumero
{
    public class Ad
    {
        public int Adivinhar()
        {
            Console.WriteLine("\nAdivinhe o número entre 1 e 100 (ou digite 0 para sair):\n");
            int numero = new Random().Next(1, 101);
            int tentativas = 0;

            while (tentativas < 10)
            {
                Console.WriteLine("Digite seu palpite (0 para sair):\n");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("\nVocê saiu do jogo.\n");
                    return -1;
                }

                int palpite;
                if (!int.TryParse(input, out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro de 1 - 100 ou 0 para sair.\n");
                    continue;
                }

                tentativas++;

                if (palpite == numero)
                {
                    Console.WriteLine($"\nParabéns! Você acertou em {tentativas} tentativas.\n");
                    return tentativas;
                }
                else if (palpite > numero)
                {
                    Console.WriteLine("\nTente um número menor.\n");
                }
                else
                {
                    Console.WriteLine("\nTente um número maior.\n");
                }
            }

            Console.WriteLine("Você excedeu o número máximo de tentativas (10). O número correto era: \n" + numero);
            return -1;
        }
    }
}
