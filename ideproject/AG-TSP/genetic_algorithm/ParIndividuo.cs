using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class ParIndividuo
    {
        public Individuo individuoA { get; }
        public Individuo individuoB { get; }

        public ParIndividuo(Individuo individuoA, Individuo individuoB)
        {
            this.individuoA = individuoA;
            this.individuoB = individuoB;
        }
    }
}
