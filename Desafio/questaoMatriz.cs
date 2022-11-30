using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questaoMatriz
    {
        //Faça um programa que leia os elementos de uma matriz 4x4 de inteiros e,
        //após a leitura de todos os elementos da matriz, exiba a matriz lida e o maior
        //número de cada linha da matriz.

        static void Main1(string[] args)
        {
            int[,] var = new int[4, 4];

            int maiorValor = 0;
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var[i, j] = int.Parse(Console.ReadLine());

                    if (var[i,j] > maiorValor)
                    {
                        maiorValor = var[i,j];
                    }
                }
            }

            Console.WriteLine("o maior valor e " + maiorValor);
        }
    }
}
