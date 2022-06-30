using System.Collections.Generic;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public static class RandomNumber
    {
        public static List<int> RandomNumbers(int inicio, int fim)
        {
            List<int> numeros = new List<int>();

            for (int i = inicio; i < fim; i++)
            {
                numeros.Add(i);
            }

            for (int i = 0; i < numeros.Count; i++)
            {
                int a = Configuracao.aleatorio.Next(numeros.Count);
                int tmp = numeros[i];
                numeros[i] = numeros[a];
                numeros[a] = tmp;
            }
            return numeros.GetRange(0, fim);
        }


    }
}