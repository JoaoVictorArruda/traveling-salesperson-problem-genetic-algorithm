using System;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public static class Configuracao
    {
        public static int tamanhoCromossomo = 0;
        public static int tamanhoPopulacao = 100;
        public static Random aleatorio = new Random((int)DateTime.Now.Ticks);
        public static double taxaCrossover = 0.8;
        public static double taxaMutacao = 0.01;
        public static int numeroCompetidores = 3;
        public static Tipo tipo = Tipo.FIXO;

        public enum Tipo
        {
            DHM_ILC,
            ILM_DHC,
            FIXO
        }
    }
}
