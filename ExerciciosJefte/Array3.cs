using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosJefteArray
{
    class Array3
    {
        static void Main(string[] args)
        {
            int[] vet = new int[100];

            Random aleatorio = new Random();

           
            for (int i = 0; i < 100; i++)
            {               
                vet[i] = aleatorio.Next();
            }

            int contador = 0;

            for (int j = 0; j < 100; j++)
            {
                if (vet[j] % 2 != 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Existem {contador} números ímpares no array.");



        }
    }
}
