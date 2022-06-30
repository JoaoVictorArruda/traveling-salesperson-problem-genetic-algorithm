using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.solucao
{
    //Implementa a estratégia para solução do problema considerando o limite de gerações
    class SolucaoLimiteGeracao : ISolucao
    {
        private int limite;

        public SolucaoLimiteGeracao(int limite)
        {
            this.limite = limite;
        }

        public bool solucionado(Populacao populacao)
        {
            return populacao.geracao >= limite;
        }
    }
}
