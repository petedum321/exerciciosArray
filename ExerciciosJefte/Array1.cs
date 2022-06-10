using System;

namespace ExerciciosJefteArray
{
    class Array1
    {
        static void NotMain(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[20];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o valor da posição {i} do primeiro vetor: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Digite o valor da posição {j} do segundo vetor: ");
                vet2[j] = int.Parse(Console.ReadLine());
            }

            int contador1 = 0;
            int contador2 = 0;
            for (int k = 0; k < 20; k++)
            {
                if (k % 2 == 0)
                {
                    vet3[k] = vet1[contador1];
                    contador1++;
                }
                else
                {
                    vet3[k] = vet2[contador2];
                    contador2++;
                }
            }

            int c1 = 0;
            int c2 = 0;
            int c3 = 0;

            
            Console.WriteLine("VETOR 1: ");
            foreach (var item in vet1)
            {
                c1++;
                Console.WriteLine($"Vetor1[{c1}] = {item}");
            }
            Console.WriteLine("VETOR 2: ");
            foreach (var item in vet2)
            {
                c2++;
                Console.WriteLine($"Vetor2[{c2}] = {item}");
            }
            Console.WriteLine("VETOR 3: ");
            foreach (var item in vet3)
            {
                c3++;
                Console.WriteLine($"Vetor3[{c3}] = {item}");
            }

        }
    }
}
