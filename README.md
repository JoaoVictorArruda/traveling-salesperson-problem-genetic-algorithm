<!-- Visualizador online: https://stackedit.io/ -->
 ![Logo da UDESC Alto Vale](http://www1.udesc.br/imagens/id_submenu/2019/marca_alto_vale_horizontal_assinatura_rgb_01.jpg)

---

# Algoritmo genético aplicado no Problema do Caixeiro Viajante

Algoritmo desenvolvido no âmbito acadêmico para a disciplina de Inteligência Artificial do [Centro de Educação Superior do Alto Vale do Itajaí (CEAVI/UDESC)](https://www.udesc.br/ceavi). Os autores da simulação são:

 - [**João Victor Arruda**](mailto:jvanunes1@gmail.com)
 - [**Lucas Fusinato Zanis**](mailto:lucasfusinato-17@hotmail.com)

# Sumário
* [Problema](#problema)
* [Dataset](#dataset)
* [Técnica](#tecnica)

## [Problema](#problema)
O Problema do Caixeiro Viajante (PCV) é um problema que tenta determinar a menor rota para percorrer uma série de cidades (visitando uma única vez cada uma delas), retornando à cidade de origem. Ele é um problema de otimização NP-difícil inspirado na necessidade dos vendedores em realizar entregas em diversos locais (as cidades) percorrendo o menor caminho possível, reduzindo o tempo necessário para a viagem e os possíveis custos com transporte e combustível.
## [Dataset](#dataset)
Uma interface permite o usuário desenhar a posição das cidades. Além de um arquivo (dataset.txt) para importação com as coordenadas de um plano cartesiano, onde cada ponto representa uma cidade.
## [Técnica](#tecnica)
Nesse problema, o cromossomo é representado por um vetor de inteiros. Onde cada posição desse vetor representa um gene e cada gene é uma cidade. O Fitness de cada individuo é a distância total a ser percorrida.