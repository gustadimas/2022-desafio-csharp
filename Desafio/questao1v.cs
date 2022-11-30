using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questao1v
    {
        // Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.

        static void Main3(string[] args)
        {
            int[] var = new int[5];

            for (var i = 0; i < 5; i++)
            {
                var[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(var[i]);
            }
        }
    }
}
