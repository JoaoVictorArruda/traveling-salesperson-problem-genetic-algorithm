using System;
using System.Collections.Generic;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class Individuo
    {
        public int[] cromossomo { get; set; }
        public double aptidao { get; set; }
        public int index { get; set; }

        public Individuo(int[] cromossomo)
        {
            this.cromossomo = cromossomo;
        }
    }
}
