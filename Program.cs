using System;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10]  { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6};

            Console.WriteLine("Vetores não Ordenados");
            mostraVetor(vetor);

            Console.WriteLine("Vetores que Foram Ordenados");

            mostraVetor(InsertSort(vetor));


            Console.ReadKey();


        }

        private static int[] InsertSort(int[] vetor)
        {

            for (int i = 0; i < vetor.Length -1; i++)
            {
                for (int j = i +1; j>0; j--)
                {

                    if (vetor[j -1] > vetor[j])
                    {
                        int aux = vetor[j - 1];
                        vetor[j - 1] = vetor[j];

                        vetor[j] = aux;

                   }
                }
            }


            
            return vetor;
        }

        private static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);


            }
        }
    }
}
