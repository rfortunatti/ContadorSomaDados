using System;

namespace SomaDadosGerador
{
    class Gerador
    {
        static void Main()
        {
            Random rnd = new Random();

            int[] sumVet;
            sumVet = new int[18];
            int numSum = 0;

            for(int i = 0; i <= 17; i++)
            {
                sumVet[i] = 0;
            }

            for(int i = 0; i <= 10000; i++)
            {
                numSum += rnd.Next(1, 7);
                numSum += rnd.Next(1, 7);
                numSum += rnd.Next(1, 7);
                sumVet[numSum - 1]++;
                numSum = 0;
            }

            for(int i = 2; i <= 17; i++)
            {
                Console.WriteLine("Soma {0}: {1}", i+1, sumVet[i]);
            }
            
            //Console.ReadKey();
        }
    }
}