(Questão retirada de Concurso: 2015 - MPCM-PA - Técnico em Informática – Desenvolvimento) Um vetor a possui 10 posições para armazenar números inteiros (considere as posições de 1 a 10), e desejamos escrever um algoritmo para que cada posição contenha um valor maior ao anterior {vetor crescente). Selecione a alternativa que descreva um algoritmo que nao cumpre com esse objetivo

Questão 1Escolha uma opção:

[X] para I de 1 até 10 ---- ERRADA TBM?

    a[I] = I + 1

fim_para

[X] para I de 1 até 10 --- errada

    a[I] = I + I

fim_para

[ ] para I de 1 até 10

    a[I] = I - 1

fim_para

[ ] para I de 1 até 10

    a[I] = I

fim_para

[ ] para I de 1 até 10

    a[I] = 10 – I

fim_para

---

(Questão retirada de Concurso: 2019 - IF Goiano - Técnico de Tecnologia da Informação) Considere um vetor de números inteiros, em que se deseja buscar um dos elementos que está presente neste vetor. O algoritmo de busca binária requer que:

Questão 2Escolha uma opção:

[ ] os elementos do vetor sejam números primos

[X] os elementos do vetor estejam ordenados.

[ ] o vetor tenha 2n elementos, tal que n é um número inteiro maior do que zero.

[ ] o vetor tenha elementos repetidos

---

(Questão retirada de Concurso: 2018 - INB - Analista de Sistemas) Qual o algoritmo de busca que se baseia no princípio de dividir os dados na posição central, testando o elemento a ser encontrado com o elemento que está nessa posição (central)? Considere que, caso o elemento sendo buscado não seja o elemento central, então metade do conjunto de dados já pode ser descartado.

Questão 3Escolha uma opção:

[X] Busca binária

[ ] Busca sequencial

[ ] Busca serial

[ ] Busca ordenada

---

Questão retirada de Concurso: 2013 - MPE-AM - Agente de Apoio – Programador) Considere o vetor vet a seguir:

![](https://avaead.unisanta.br/pluginfile.php/523764/question/questiontext/880527/3/522875/Imagem2.png)

Após a execução dos seguintes comandos de atribuição:

aux = vet[8]

vet[8] = vet [1]

vet[4] = vet[6]

vet[6] = vet[3]

vet[1] = aux

vet[3] = vet[1]

A configuração do vetor (do índice 1 ao 8) será

Questão 4Escolha uma opção:

[X] AMASZONA --- errada

[ ] ZONAAMAS

[ ] SMAZONAS

[ ] AMAZONAS

[ ] AMASSONA

---

(Questão retirada de Concurso: Petrobrás - Analista de Sistemas Júnior - Engenharia de Software – 2012) Seja um vetor de inteiros com 400 elementos distintos ordenados em ordem crescente.

Qual é o número máximo de iterações necessárias para encontrar um elemento qualquer do vetor caso seja utilizado o algoritmo de busca binária?

Questão 5Escolha uma opção:

[ ] 7

[ ] 8

[X] 9

[ ] 400

[ ] 200

---

Questão retirada de Concurso: 2014 - CEFET-RJ - Técnico de Laboratório – Informática) Considere o seguinte algoritmo, descrito em pseudocódigo, que manipula um vetor de oito posições, indexadas de 1 a 8

variáveis

    I, TEMP: inteiro

    M: vetor [1..8] inteiro

Início

M = [10, 20, 30, 40, 50, 60, 70, 80]

para I = 1 até 8 faça

    TEMP = M[I]

    M[I] = M[9 – I]

    M[9 – I] = TEMP

fim_para

fim

Ao final da execução, o conteúdo do vetor M será

Questão 6Escolha uma opção:

[ ] 40, 30, 20, 10, 80, 70, 60, 50

[ ] 40, 10, 80, 20, 70, 30, 60, 50

[ ] 10, 20, 30, 40, 50, 60, 70, 80 ---- testei essa

[X] 80, 70, 60, 50, 40, 30, 20, 10 ---- errada

[ ] 50, 60, 70, 80, 10, 20, 30, 40

---

(Questão retirada de Concurso: - 2019 - UFSC - Técnico de Tecnologia da Informação) Considere o problema de ordenar em ordem crescente o array formado pelos números [67, 23, 11, 18, 87, 44] utilizando o Método da Seleção Direta (Selection Sort). Assinale a alternativa que mostra o posicionamento dos números no array após ter sido realizada a primeira troca.

Questão 7Escolha uma opção:

[ ] [23, 67, 11, 18, 87, 44] gemini deu esse

[ ] [67, 23, 87, 18, 11, 44]

[X] [11, 23, 67, 18, 87, 44]

[ ] [67, 11, 23, 18, 87, 44]

[ ] [44, 23, 11, 18, 87, 67]

---

(Questão retirada de Concurso: 2015 - TCE-SP - Agente de Fiscalização Financeira - Sistemas, Gestão de Projetos e Governança de TI) O seguinte algoritmo foi concebido na forma de uma pseudo-linguagem (Português Estruturado). Utilize-o para responder à questão.

variáveis

    I, J, K: inteiro

    EST: matriz [1..2,1..3,1..4] inteiro

início

para I = 1 até 2 faça

    para J = 1 até 3 faça

para K = 1 até 4 faça

    EST[I,J,K] = 3*I + 2*J + K

    fim_para

    fim_para

fim_para

escreva EST[2,2,2] – EST [1,2,3]

fim

No algoritmo apresentado, o número de posições atualizadas da matriz Est é igual a

Questão 8Escolha uma opção:

[ ] 27

[ ] 9

[ ] 64

[ ] 4

[X] 24

---

(Questão retirada de Concurso: 2010 - Colégio Pedro II - Técnico de Tecnologia da Informação) Em algoritmos e estruturas de dados existe um tipo de estrutura chamada vetor. Sobre vetores, assinale a alternativa INCORRETA.

Questão 9Escolha uma opção:

[ ] Vetor também é conhecido como variável composta homogênea unidimensional.

[ ] Como as variáveis tem o mesmo nome, o que as distingue é um índice que referencia sua localização dentro da estrutura.

[ ] Em pseudocódigo, uma sintaxe válida de atribuição em um vetor pode ser:

X[1] <- 45

[X] Na seguinte declaração: gemini deu essa ---- errada

1 DECLARE nome[tamanho] tipo

“nome” é o nome da variável, “tamanho” é a quantidade de variáveis que vão compor o vetor e “tipo” é o tipo básico dos dados que serão armazenados no vetor.

[X] Trata-se de variáveis do mesmo tipo, que possuem um mesmo identificador (nome), e são alocadas aleatoriamente na memória. --- segunda tentativa

---

(Questão retirada de Prova 2011 - FINEP - Analista de Desenvolvimento de Sistemas.) Seja o seguinte vetor, ordenado de forma ascendente:

![](https://avaead.unisanta.br/pluginfile.php/523764/question/questiontext/880527/2/522870/Imagem1.jpg)

Caso se utilize um algoritmo de pesquisa binária, quantas iterações serão necessárias para que o valor 80 seja encontrado?

Questão 10Escolha uma opção:

[X] 2 ----segunda tentativa ERRADA ??

[ ] 9

[ ] 8

[ ] 3 SO PODE SER ESSA

[X] 4 -----errada

---

(Questão retirada de Prova do Enade) Considere uma situação em que um professor que queira saber se existem alunos cursando, ao mesmo tempo, as disciplinas A e B, tenha implementado um programa que:

1. inicializa um array a de 30 posições que contém as matrículas dos alunos da disciplina A;
2. inicializa um outro array b de 40 posições, que contém as matrículas dos alunos da disciplina B;
3. imprime a matrícula dos alunos que estão cursando as disciplinas A e B ao mesmo tempo.

Considere, ainda, que os arrays foram declarados e inicializados, não estando necessariamente ordenados, e seus índices variam entre 0 e n – 1, sendo n o tamanho do array.

1. para I de 0 até 29 faça
2. para J de 0 até 39 faça
3.
4.
5.
6. fim_para
7. fim_para

Com base nessas informações, conclui-se que o trecho a ser incluído nas linhas 3, 4 e 5 do código acima, para que o programa funcione corretamente, é

Questão 9Escolha uma opção:

[X] se A[I] = B[J]

    escreva A[I]

    fim_se

[ ] se A[I] = B[J]

    escreva A[J]

    fim_se

[ ] se A[I] = B[I]

    escreva A[I]

    fim_se

[ ] se A[J] = B[I]

    escreva A[J]

    fim_se

[ ] se A[J] = B[J]

    escreva A[J]

    fim_se

---

(Questão retirada de Concurso: 2018 - INB - Analista de Sistemas) Qual o algoritmo de busca que se baseia no princípio de dividir os dados na posição central, testando o elemento a ser encontrado com o elemento que está nessa posição (central)? Considere que, caso o elemento sendo buscado não seja o elemento central, então metade do conjunto de dados já pode ser descartado.

Questão 10Escolha uma opção:

[ ] Busca serial

[ ] Busca sequencial

[x] Busca binária

[ ] Busca ordenada
