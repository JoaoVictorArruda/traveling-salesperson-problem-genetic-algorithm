using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.selecao
{
    //Implementa a estratégia de seleção com a técnica de torneio
    public class SelecaoTorneio : ISelecao
    {
        private int quantidadeCompetidores;
        private Random random;

        public SelecaoTorneio(int quantidadeCompetidores, Random random)
        {
            this.quantidadeCompetidores = quantidadeCompetidores;
            this.random = random;
        }

        public Individuo selecionar(Populacao populacao)
        {
            Individuo[] competidores = new Individuo[this.quantidadeCompetidores];
            for (int i = 0; i < competidores.Length; i++)
            {
                competidores[i] = populacao.individuos[this.random.Next(0, populacao.tamanho - 1)];
            }
            return torneio(competidores);
        }

        private Individuo torneio(Individuo[] competidores)
        {
            Individuo vencedor = null;
            for (int i = 0; i < competidores.Length; i++)
            {
                Individuo atual = competidores[i];
                if (vencedor == null || atual.aptidao < vencedor.aptidao)
                {
                    vencedor = atual;
                }
            }
            return vencedor;
        }
    }
}
