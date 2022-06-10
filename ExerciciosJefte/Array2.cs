using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosJefteArray
{
    class Array2
    {
        static void NotMain(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite valor na posicao {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int indiceMaior = Array.IndexOf(array, array.Max());
            int indiceMenor = Array.IndexOf(array, array.Min());

            Console.WriteLine($"Maior valor do array: {array.Max()}, posicao:  {indiceMaior}");
            Console.WriteLine($"Menor valor do array: {array.Min()}, posicao: {indiceMenor} ");


        }
    }
}
