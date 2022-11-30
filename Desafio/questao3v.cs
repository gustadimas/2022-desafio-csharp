using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class questao3v
    {
        //Faça um Programa que leia 6 números inteiros e armazene-os num vetor.
        //Armazene os números positivos no vetor POS e os números negativos novetor NEG.
        //Imprima os três vetores.

        static void Main5(string[] args)
        {
            int[] var = new int[6];

            int[] pos = new int[6];
            int[] neg = new int[6];

            for (int i = 0; i < 6; i++)
            {
                var[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                if (var[i] > 0)
                {
                    pos[i] = var[i];
                }

                else if (var[i] < 0)
                {
                    neg[i] = var[i];
                }
            }

            string numerosNeg = "";
            string numerosPos = "";

            for (int i = 0; i < pos.Length; i++)
            {
                numerosPos += pos[i].ToString() + ", ";
            }

            for (int i = 0; i < neg.Length; i++)
            {
                numerosNeg += neg[i].ToString() + ", ";
            }

            Console.WriteLine("Os valores positivos são: " + numerosPos);
            Console.WriteLine("Os valores negativos são: " + numerosNeg);
        }
    }
}
