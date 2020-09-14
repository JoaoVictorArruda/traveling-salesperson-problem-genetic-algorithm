using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public interface IAlgoritmoGeneticoObserver
    {
        void notifyInicioGeracao();

        void notifyAtualizacaoFitness();
    }
}
