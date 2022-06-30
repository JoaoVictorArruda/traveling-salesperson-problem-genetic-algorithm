using System.Collections.Generic;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.aptidao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.crossover;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.mutacao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.selecao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.solucao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.substituicao;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class AlgoritmoGenetico
    {
        //Estratégias utilizadas no algoritmo
        public IAptidao aptidao { get; set; }
        public ICrossover crossover { get; set; }
        public IMutacao mutacao { get; set; }
        public ISelecao selecao { get; set; }
        public ISolucao solucao { get; set; }
        public ISubstituicao substituicao { get; set; }

        //Observadores do algoritmo
        public List<IAlgoritmoGeneticoObserver> observadores { get; }

        public AlgoritmoGenetico()
        {
            this.observadores = new List<IAlgoritmoGeneticoObserver>();
        }

        public void execute(Populacao populacao)
        {
            populacao.geracao += 1;

            //Notifica os observadores que uma nova geração vai iniciar
            notifyInicioGeracao();

            //Avalia os indivíduos da população de acordo com a função de aptidão
            foreach (Individuo individuo in populacao.individuos)
            {
                individuo.aptidao = aptidao.calcular(individuo);
            }

            //Notifica os observadores que o fitness foi atualizado
            notifyAtualizacaoFitness();

            //Verifica se o critério de parada foi atingido
            if (solucao.solucionado(populacao))
            {
                //Finaliza a execução do algoritmo
                return;
            }

            //Cria uma lista com os indivíduos da próxima geração
            List<Individuo> novosIndividuos = new List<Individuo>();
            for (int i = 0; i < populacao.tamanho; i++)
            {
                novosIndividuos.Add(populacao.individuos[i]);
            }   

            //Aplica as técnicas do algoritmo genético para evoluir a próxima geração (seleção, cruzamento e mutação)
            for (int i = 0; i < (populacao.tamanho / 2); i++)
            {
                //Selecione os indivíduos para cruzamento
                Individuo individuo = selecao.selecionar(populacao);
                Individuo individuo2 = selecao.selecionar(populacao);

                //Verifica a taxa de crossover
                if (crossover.verificar())
                {
                    //Realiza o cruzamento dos indivíduos, gerando dois filhos
                    ParIndividuo filhos = crossover.cruzar(individuo, individuo2);
                    
                    //Realiza a mutação dos indivíduos
                    mutacao.mutar(filhos.individuoA);
                    mutacao.mutar(filhos.individuoB);

                    filhos.individuoA.index = individuo.index;
                    filhos.individuoB.index = individuo2.index;

                    //Adiciona os novos indivíduos na população
                    novosIndividuos[individuo.index] = filhos.individuoA;
                    novosIndividuos[individuo2.index] = filhos.individuoB;
                }
                else
                {
                    novosIndividuos[individuo.index] = individuo;
                    novosIndividuos[individuo2.index] = individuo2;
                }
            }
            
            //Substitui os indivíduos da população
            substituicao.substituir(populacao, novosIndividuos);

            //Avança para a próxima geração do algoritmo de forma recursiva
            execute(populacao);
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
