using System.Collections.Generic;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class AlgoritmoGenetico
    {
        public List<IAlgoritmoGeneticoObserver> observadores { get; }

        public AlgoritmoGenetico()
        {
            this.observadores = new List<IAlgoritmoGeneticoObserver>();
        }

        public void execute(Populacao populacao)
        {
            notifyInicioGeracao();
            notifyAtualizacaoFitness();
        }

        private void notifyInicioGeracao()
        {
            foreach (IAlgoritmoGeneticoObserver observador in observadores)
            {
                observador.notifyInicioGeracao();
            }
        }

        private void notifyAtualizacaoFitness()
        {
            foreach (IAlgoritmoGeneticoObserver observador in observadores)
            {
                observador.notifyAtualizacaoFitness();
            }
        }
    }
}
