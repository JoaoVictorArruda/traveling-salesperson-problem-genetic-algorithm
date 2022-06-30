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
* [Resultados Obtidos](#resultados)
* [Instruções de uso do software](#instrucoes)
* [Vídeo](#video)

## [Problema](#problema)
O Problema do Caixeiro Viajante (PCV) é um problema que tenta determinar a menor rota para percorrer uma série de cidades (visitando uma única vez cada uma delas), retornando à cidade de origem. Ele é um problema de otimização NP-difícil inspirado na necessidade dos vendedores em realizar entregas em diversos locais (as cidades) percorrendo o menor caminho possível, reduzindo o tempo necessário para a viagem e os possíveis custos com transporte e combustível.

## [Dataset](#dataset)
Uma interface permite o usuário desenhar a posição das localidades. Além de um arquivo (berlin52.txt) para importação com as coordenadas de um plano cartesiano, onde cada ponto representa uma localidade em Berlim. O dataset pode ser encontrado em [Ruprecht-Karls-Universität Heidelberg](http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/tsp/).

## [Técnica](#tecnica)
Para resolver o problema do caixeiro viajante foram utilizados algoritmos genéticos.
Os detalhes da implementação do algoritmo são descritos abaixo.

### Representação do Indivíduo
- O cromossomo é representado por um array de números inteiros
- Cada número representa o identificador de uma localidade no mapa
- Dessa forma, o tamanho do array será a quantidade de localidades existentes
- A sequência do array representa a ordem em que o indivíduo deve passar em cada localidade
- Os valores do array são únicos, pois o problema define que não pode repetir os lugares
- Por exemplo, para um mapa com 5 cidades, o cromossomo de um determinado indivíduo pode ser representado por: [5,3,2,4,1], o que significa que ele passaria em ordem pelas cidades 5 -> 3 -> 2 -> 4 -> 1 -> 5 para resolver o problema

### Cálculo da Aptidão
- A aptidão de cada indivíduo é calculada pelo somatório das distâncias entre cada par de localidade do cromossomo
- O melhor indivíduo é aquele que possui o menor valor de aptidão, pois o objetivo é encontrar o organismo que percorre a menor distância

### Critério de Parada
- O algoritmo termina quando é atingido um determinado número de gerações
- O número de gerações executadas pode ser configurado através da interface da aplicação

### Estratégia de Seleção
- Foi utilizada a seleção por torneio, onde um grupo de indivíduos é selecionado aleatoriamente, e deste grupo é escolhido o melhor indivíduo
- O número de indivíduos que participarão do torneio pode ser configurado através da interface da aplicação

### Estratégia de Crossover
- Para cada par de indivíduos selecionados a partir do torneio, é gerado um número aleatório para verificar se devem ser cruzados, considerando uma taxa de crossover
- A taxa de crossover pode ser configurada através da interface da aplicação
- O cruzamento é realizado com a técnica de Partially Mapped Crossover, ou PMX. Neste método, é escolhido aleatóriamente pontos de corte no cromossomo pai para gerar um cromossomo filho, no pedaço entre os cortes, é realizado um mapeamento dos valores de um pai para os valores do outro, de forma que os valores são ajustados de forma a retirar qualquer valor duplicado no crossomo filho.
- Nessa técnica, inicialmente os indivíduos que farão o crossover são permutados com o corte em dois pontos aleatórios, e em seguida são tratados valores restantes que estão duplicados
- Essa estratégia é importante para garantir valores únicos no cromossomo, conforme especificado anteriormente

### Estratégia de Mutação
- Para cada indivíduo gerado a partir do cruzamento, é gerado um número aleatório para verificar se deve sofrer mutação, considerando uma taxa de mutação
- A taxa de mutação pode ser configurada através da interface da aplicação
- A mutação é realizada com a técnica de troca de valor entre dois genes escolhidos aleatoriamente

### Modelagem
O diagrama abaixo repersenta como o algoritmo foi modelado no software.

Considerando as diversas opções de implementação do algoritmo genético, optou-se por realizar uma implementação que seja escalável para que determinadas partes do algoritmo sejam alteradas sem influenciar no seu funcionamento principal.

![Diagrama do Algoritmo](https://github.com/JoaoVictorArruda/traveling-salesperson-problem-genetic-algorithm/blob/master/img/diagrama.PNG)

## [Resultados Obtidos](#resultados)

Para medir os resultados do algoritmo, foram realizados testes com:
- Diferentes quantidades de população (25, 100 e 400)
- Diferentes quantidades de geração (100, 200, 400, 600, 1000 e 1600)
- Diferentes técnicas para configuração das taxas de mutação e crossover: (DHM/ILC, ILM/DHC, 0.03MR0.9CR, FFMCR)
  * DHM/ILC(Dynamic Decreasing of High Mutation Rate/Increasing of Low Crossover Rate) - A taxa de mutação é diminuida iniciando em 100%, a taxa de cruzamento é aumentada iniciando em 0%. Fórmulas:
    * Taxa de mutação: 1 - (geraçãoAtual/totalGerações);
    * Taxa de cruzamento: geraçãoAtual/totalGerações;
  * ILM/DHC(Dynamic Increasing of Low Mutation/Decreasing of High Crossover) - O oposto da técnica DHM/ILC, sendo a taxa de cruzamento iniciando em 100% e a taxa de mutação iniciando em 0%. Fórmulas:
    * Taxa de mutação: geraçãoAtual/totalGerações;
    * Taxa de cruzamento: 1 - (geraçãoAtual/totalGerações);
  * 0.03MR0.9CR - A taxa de cruzamento fixa em 90% e taxa de mutação 3%.
  * FFMCR (Fixed 50% for Mutation and Crossover Rates) - Ambas as taxas de cruzamento e mutação são fixas em 50%.

Para definição dos resultados, foi obtida a média de 5 execuções do programa para cada combinação dos testes destacados acima.

O gráfico abaixo mostra os resultados na execução do algoritmo considerando uma população de 25 indivíduos
![Resultado População 25](https://github.com/JoaoVictorArruda/traveling-salesperson-problem-genetic-algorithm/blob/master/img/resultado-25.PNG)

O gráfico abaixo mostra os resultados na execução do algoritmo considerando uma população de 100 indivíduos
![Resultado População 100](https://github.com/JoaoVictorArruda/traveling-salesperson-problem-genetic-algorithm/blob/master/img/resultado-100.PNG)

O gráfico abaixo mostra os resultados na execução do algoritmo considerando uma população de 400 indivíduos
![Resultado População 400](https://github.com/JoaoVictorArruda/traveling-salesperson-problem-genetic-algorithm/blob/master/img/resultado-400.PNG)

É possível verificar nos três gráficos apresentados acima, que:
- Quanto maior a quantidade de indivíduos, melhor é a solução do algoritmo
- Quanto maior a quantidade de gerações, melhor é a solução do algoritmo, porém esta para de ter melhorias significativas em um certo ponto
- Para todas as quantidades de indivíduos, a técnica de definição das taxas de mutação e crossover de DHM/ILC foi a que mais evoluiu considerando o resultado de 100 gerações e de 1600 gerações
- O melhor resultado obtido foi com a população de 400 indivíduos, após 1600 gerações com a técnica de ILM/DHC para configuração das taxas de mutação e crossover, neste caso obtendo-se a distância de 9.808,09

## [Instruções de Uso do Software](#instrucoes)

O software pode ser executado através do download do projeto em formato ZIP pelo Github, ou também através da execução do comando abaixo no terminal:
`git clone https://github.com/JoaoVictorArruda/traveling-salesperson-problem-genetic-algorithm.git`

Em ambos os casos, deve ser acessada a pasta *build*, e dentro dela executar o arquivo *setup.exe* para instalação do programa. Por fim, basta abrir o arquivo *traveling-salesperson-problem-genetic-algorithm.application* para abrir o programa.

A interface do sistema é única, permitindo a configuração do mapa/dataset, e as configurações do algoritmo genético.

Para execução do algoritmo, deve-se criar ou selecionar um mapa com no mínimo 4 pontos, em seguida clicar no botão *Criar população*, e por fim clicar no botão *Executar/Continuar*.

## [Vídeo](#video)

Vídeo 1: Apresentação do Problema e Técnica utilizada
https://youtu.be/P_LtOJY66kA

Vídeo 2: Especificação do Software e Resultados Obtidos
https://youtu.be/gndubYP6-rw

Vídeo 3: Demonstração do Sistema e Conclusão
https://youtu.be/J_wNnMlD0Sk
