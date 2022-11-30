using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questao1m
    {
        //Leia uma matriz 4 x 4, conte e escreva quantos valores maiores que 10 ela possui

        static void Main6(string[] args)
        {
            int[,] var = new int[4, 4];

            int quantiaMaior10 = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var[i, j] = int.Parse(Console.ReadLine());

                    if (var[i, j] > 10)
                    {
                        quantiaMaior10++;
                    }
                }
            }

            Console.WriteLine("quantia maior que 10: " + quantiaMaior10);
        }

    }
}
