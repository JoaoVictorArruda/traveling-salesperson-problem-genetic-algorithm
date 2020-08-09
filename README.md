<!-- Visualizador online: https://stackedit.io/ -->
 ![Logo da UDESC Alto Vale](http://www1.udesc.br/imagens/id_submenu/2019/marca_alto_vale_horizontal_assinatura_rgb_01.jpg)

---

# Algoritmo genético aplicado no Problema do Caixeiro Viajante

Algoritmo desenvolvido no âmbito acadêmico para a disciplina de Inteligência Artificial do [Centro de Educação Superior do Alto Vale do Itajaí (CEAVI/UDESC)](https://www.udesc.br/ceavi). Os autores da simulação são:

 - [**João Victor Arruda**](mailto:jvanunes1@gmail.com) - [JoaoVictorArruda](https://github.com/JoaoVictorArruda)
 - [**Lucas Fusinato Zanis**](mailto:lucasfusinato-17@hotmail.com) - [lucasfusinato](https://github.com/lucasfusinato)

# Sumário
* [Problema](#problema)
* [Dataset](#dataset)
* [Técnica](#tecnica)

## [Problema](#problema)
O Problema do Caixeiro Viajante (PCV) é um problema que tenta determinar a menor rota para percorrer uma série de cidades (visitando uma única vez cada uma delas), retornando à cidade de origem. Ele é um problema de otimização NP-difícil inspirado na necessidade dos vendedores em realizar entregas em diversos locais (as cidades) percorrendo o menor caminho possível, reduzindo o tempo necessário para a viagem e os possíveis custos com transporte e combustível.

## [Dataset](#dataset)
Uma interface permite o usuário desenhar a posição das cidades. Além de um arquivo (berlin52.txt) para importação com as coordenadas de um plano cartesiano, onde cada ponto representa uma cidade. O dataset pode ser encontrado em [Ruprecht-Karls-Universität Heidelberg](http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/tsp/).

## [Técnica](#tecnica)
Para a aplicação do algoritmo genético nesse problema, teremos um vetor de inteiros que representao caminho a ser percorrido.Para representar esses caminhos, um vetor de tamanho n (sendo n=total de cidade) é criado.

### Exemplo para um problema com 3 cidades:

#### Possiveis caminhos -> representação em vetor
* 1 -> 2 -> 3 => [1,2,3]
* 1 -> 3 -> 2 => [1,3,2]
* 2 -> 1 -> 3 => [2,1,3]
* 2 -> 3 -> 1 => [2,3,1]
* 3 -> 1 -> 2 => [3,1,2]
* 3 -> 2 -> 1 => [3,2,1]

Dessa forma, para calcular o fitness de cada individuo basta iterar o vetor somando a distância da cidade n com cidade n+1. Já que nesse problema estamos procurando o menor caminho, é considerado o melhor individuo aquele que possui menor fitness.
