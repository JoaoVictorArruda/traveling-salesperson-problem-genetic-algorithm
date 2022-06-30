

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class Populacao
    {
        public Individuo[] individuos { get; set; }
        public int tamanho { get; set; }
        public int geracao { get; set; }

        public Populacao(int tamanho)
        {
            this.individuos = new Individuo[tamanho];
            this.tamanho = tamanho;
        }

        public Populacao(Individuo[] individuos)
        {
            this.individuos = individuos;
            this.tamanho = this.individuos.Length;
            for(int i = 0; i < this.tamanho; i++)
            {
                this.individuos[i].index = i;
            }
        }

        public Individuo[] getPopulacao()
        {
            return this.individuos;
        }

        public void setIndividuo(int position, Individuo individuo)
        {
            this.individuos[position] = individuo;
        }

        public double getMediaPopulacao()
        {
            double soma = 0;

            foreach (Individuo ind in this.individuos)
            {
                soma += ind.aptidao;
            }

            return (soma / Configuracao.tamanhoPopulacao);
        }

        private void ordenarPopulacao()
        {
            Individuo individuo;

            for (int i = 0; i < Configuracao.tamanhoPopulacao; i++)
            {
                for (int j = 0; j < Configuracao.tamanhoPopulacao; j++)
                {
                    if (individuos[i].aptidao < individuos[j].aptidao)
                    {
                        individuo = individuos[i];
                        individuos[i] = individuos[j];
                        individuos[j] = individuo;
                    }
                }
            }
        }

        public Individuo getMelhorIndividuo()
        {
            ordenarPopulacao();
            return individuos[0];
        }
    }
}
