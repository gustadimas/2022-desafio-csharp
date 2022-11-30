using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questao2m
    {
        //Leia uma matriz 4 x 4 com valores diferentes. Leia também um valor X. O
        //programa deverá fazer uma busca desse valor na matriz e, ao final, escrever a
        //localização(linha e coluna) ou uma mensagem de “não encontrado”.

        static void Main(string[] args)
        {
            int[,] tabela = new int[2, 2] 
            {
                {78, 85}, {5, 10}          
            };

            int linhas = -1;
            int colunas = -1;

            Console.WriteLine("digite a disgraça de um numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (tabela[i, j] == numero)
                    {
                        linhas = i;

                        colunas = j;
                    }
                }
            }

            if (linhas != -1 && colunas != -1)
            {
                Console.WriteLine("A localização do numero é: " + linhas + " " + colunas);
            }

            else
            {
                Console.WriteLine("Não encontrado!");
            }
        }
    }
}
