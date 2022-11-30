using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questao2v
    {
        //Faça um Programa que leia um vetor de 10 números reais e mostre-os na
        //ordem inversa

        static void Main4(string[] args)
        {
            int[] var = new int[10];

            for (int i = 0; i < 10; i++)
            {
                var[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(var[i]);
            }
        }
    }
}
