using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.utils
{
    //Classe auxiliar para geração e acesso de dois pontos aleatórios
    class DoisPontos
    {
        public int maximo { get; set; }
        public int pontoA { get; set; }
        public int pontoB { get; set; }

        private Random random;

        public DoisPontos(int maximo, Random random)
        {
            this.maximo = maximo;
            this.random = random;
            gerarPontos();
        }

        public bool dentro(int valor)
        {
            return valor >= this.pontoA && valor <= this.pontoB;
        }

        public bool fora(int valor)
        {
            return !dentro(valor);
        }

        private void gerarPontos()
        {
            this.pontoA = random.Next(0, maximo);
            this.pontoB = random.Next(0, maximo);
            if(this.pontoA == this.pontoB)
            {
                this.pontoB += (this.pontoB + 1 > maximo) ? -1 : 1;
            }
            if (this.pontoA > this.pontoB)
            {
                int auxiliar = this.pontoA;
                this.pontoA = this.pontoB;
                this.pontoB = auxiliar;
            }
        }
    }
}
