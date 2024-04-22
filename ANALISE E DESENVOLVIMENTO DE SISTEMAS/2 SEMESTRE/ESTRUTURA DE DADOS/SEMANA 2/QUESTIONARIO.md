(Questão retirada de Prova 2019 - UFC - Técnico de Tecnologia da Informação) Um dos exemplos de estrutura de dados é a lista encadeada simples. Com relação a esse tipo de lista, é correto afirmar:

Questão 1Escolha uma opção:[X] Na inserção de um novo elemento, é necessário realizar a atualização dos ponteiros dos elementos envolvidos, não sendo necessário realizar o deslocamento físico dos elementos

[ ] Quando essa estrutura é utilizada, os elementos da lista sempre estarão armazenados sequencialmente na memória física

[X] Na recuperação de qualquer elemento da lista, não é necessário percorrer os outros elementos. Dessa forma, o elemento buscado é acessado diretamente na posição onde se encontra errada

[ ] É necessário definir o seu tamanho no momento da sua criação, pois se trata de uma estrutura de dados estática

[ ] Possui a característica de que o último elemento da lista possui um ponteiro para o primeiro elemento da lista

---

(Questão retirada de Prova Enade) A biblioteca de coleções da linguagem Java disponibiliza implementações de propósito geral para estruturas de dados elementares, como listas, filas e pilhas. Considere as seguintes definições de classes que representam implementações de estruturas de dados disponíveis na biblioteca da linguagem:

• Classe A: os objetos são organizados em uma ordem linear e podem ser inseridos somente no início ou no final dessa sequência;

• Classe B: os objetos são organizados em uma ordem linear determinada por uma referência ao próximo objeto;

• Classe C: os objetos são removidos na ordem oposta em que foram inseridos;

• Classe D: os objetos são inseridos e removidos respeitando a seguinte regra: o elemento a ser removido é sempre aquele que foi inserido primeiro.

Nesse contexto, assinale a alternativa que representa, respectivamente, as estruturas de dados implementadas pelas classes A, B, C e D.

Questão 2Escolha uma opção:

[X] Deque, lista simplesmente ligada, pilha e fila segunda

[ ] Lista circular, lista simplesmente ligada, pilha e fila

[ ] Deque, pilha, lista ligada e fila primeira

[ ] Pilha, fila, deque e lista simplesmente encadeada

[ ] Lista duplamente ligada, lista simplesmente ligada, fila e pilha

---

(Questão retirada de Prova Enade) No desenvolvimento de um software que analisa bases de DNA, representadas pelas letras A, C, G, T, utilizou-se as estruturas de dados: pilha e fila. Considere que, se uma sequência representa uma pilha, o topo é o elemento mais à esquerda; e se uma sequência representa uma fila, a sua frente é o elemento mais à esquerda. Analise o seguinte cenário: “a sequência inicial ficou armazenada na primeira estrutura de dados na seguinte ordem: (A,G,T,C,A,G,T,T). Cada elemento foi retirado da primeira estrutura de dados e inserido na segunda estrutura de dados, e a sequência ficou armazenada na seguinte ordem: (T,T,G,A,C,T,G,A). Finalmente, cada elemento foi retirado da segunda estrutura de dados e inserido na terceira estrutura de dados e a sequência ficou armazenada na seguinte ordem: (T,T,G,A,C,T,G,A)”. Qual a única sequência de estruturas de dados apresentadas a seguir pode ter sido usada no cenário descrito acima?

Questão 3Escolha uma opção:[ ] Pilha - Pilha - Pilha

[ ] Fila - Pilha - Pilha

[X] Fila - Pilha - Fila

[ ] Pilha - Fila - Pilha

[ ] Fila - Fila - Pilha

---

(Questão retirada de Prova [2020](https://olhonavaga.com.br/questoes/questoes?tc=1&ma=1961&as=4984&pg=2 'Inserir esse ano nos filtros')-[Exército](https://olhonavaga.com.br/questoes/questoes?tc=1&ma=1961&as=4984&pg=2 'Inserir essa organizadora nos filtros') • [Oficial do Quadro Complementar](https://olhonavaga.com.br/questoes/questoes?tc=1&ma=1961&as=4984&pg=2 'Inserir esse cargo nos filtros')) Sobre uma estrutura de dados na forma de pilha, foi aplicada a seguinte sequência de instruções:

Empilha “A”

Empilha “B”

Empilha “C”

Desempilha

Desempilha

Empilha “D”

Desempilha

Empilha “E”

Desempilha

Após a execução dessa sequência de instruções, o topo da pilha terá o elemento:

Questão 4Escolha uma opção:

[ ] A

[ ] B errada

[ ] C

[ ] D

[X] E errada

R:

- É importante notar que a questão não especifica quais elementos foram desempilhados nas instruções 4, 5, 7 e 9. Isso significa que a resposta à questão não depende da ordem em que os elementos foram empilhados na pilha.
- A pilha é uma estrutura de dados LIFO (Last In, First Out), o que significa que o último elemento que foi empilhado é o primeiro a ser desempilhado.

---

(Questão retirada de Prova 2019 - Prefeitura de Turmalina - MG - Técnico em Informática) Considere a representação de uma lista duplamente encadeada que armazena os times de futebol participantes de um torneio.

![](https://avaead.unisanta.br/pluginfile.php/523764/question/questiontext/880277/5/522894/13.png)

Questão 5Escolha uma opção:

[ ] Palmeiras, Flamengo, São Paulo, Cruzeiro, Atlético-MG

[ ] São Paulo, Flamengo, Palmeiras, Cruzeiro, Atlético-MG errada

[X] Cruzeiro, Atlético-MG, Palmeiras, Flamengo, São Paulo errada

[ ] São Paulo, Palmeiras, Flamengo, Cruzeiro, Atlético-MG

R:

**Explicação:**

- O nó com o índice 1 aponta para o nó com o índice 2, indicando que o próximo time na lista é o Atlético-MG.
- O nó com o índice 2 aponta para o nó com o índice 5, indicando que o próximo time na lista é o Palmeiras.
- O nó com o índice 5 aponta para o nó com o índice 3, indicando que o próximo time na lista é o São Paulo.
- O nó com o índice 3 aponta para o nó com o índice 5, indicando que o próximo time na lista é o Palmeiras.
- O nó com o índice 5 aponta para o nó com o índice 1, indicando que o próximo time na lista é o Cruzeiro.

---

(Questão retirada de Prova 2019 - MPC-PA - Analista Ministerial – Tecnologia da Informação) Assinale a opção que apresenta a denominação da estrutura de dados constituída por um conjunto de elementos individualizados, em que cada um dos elementos — com exceção dos elementos inicial e final — referencia sempre outros dois, um que o antecede e outro que o sucede.

Questão 6Escolha uma opção:[ ] árvore

[ ] pilha

[ ] fila

[X] lista duplamente encadeada

[ ] lista circular

R:

Uma lista duplamente encadeada é uma estrutura de dados na qual cada nó contém não apenas uma referência para o próximo nó na sequência, como em uma lista simplesmente encadeada, mas também uma referência para o nó anterior na sequência. Isso significa que cada nó da lista duplamente encadeada mantém dois ponteiros: um que aponta para o nó anterior e outro que aponta para o próximo nó na lista.

Essa característica permite uma navegação bidirecional na lista, o que significa que podemos percorrer a lista tanto do início para o fim quanto do fim para o início de forma eficiente, já que podemos acessar diretamente tanto o nó anterior quanto o próximo nó em relação a um nó específico.

Essa estrutura é particularmente útil em situações onde a inserção e remoção de elementos na lista precisam ser eficientes em ambas as direções, pois não é necessário percorrer toda a lista para chegar a um determinado nó, como seria o caso em uma lista simplesmente encadeada.

Portanto, a estrutura de dados constituída por um conjunto de elementos individualizados, em que cada um dos elementos (com exceção dos elementos inicial e final) referencia sempre outros dois, um que o antecede e outro que o sucede, é denominada lista duplamente encadeada.

---

(Questão retirada de Prova [Banco do Brasil - Agente de Tecnologia e Informática (2021)](https://www.questoesestrategicas.com.br/provas/ver/banco-do-brasil-agente-de-tecnologia-e-informatica-cesgranrio-2021 'Veja detalhes da prova Banco do Brasil - Agente de Tecnologia e Informática (2021)') Uma das formas de o gerente de uma agência bancária acompanhar a qualidade dos serviços prestados aos seus clientes é verificar o estado da ordem de atendimento em vários instantes ao longo do expediente. O sistema que a gerência utiliza para tal fim é a estrutura de dados conhecida como FILA, que mostra a situação da ordem de atendimento no instante da verificação. Nesse contexto, implementa-se uma estrutura de FILA de números inteiros com suas duas operações tradicionais: ENFILEIRAR(Z), que ocorre no instante em que um cliente recebe uma senha Z e entra na FILA; e DESENFILEIRAR![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo'), que ocorre quando um cliente sai da FILA, caso em que DESENFILEIRAR![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo') retorna o número da senha.

Sabe-se, também, que a representação do estado da FILA em um instante qualquer é realizada listando os elementos, de forma que o primeiro elemento, da esquerda para a direita, é o mais antigo presente na FILA. Nas condições apresentadas, considere uma FILA que começa vazia e realiza as seguintes operações:

ENFILEIRAR(8) → ENFILEIRAR(9) → DESENFILEIRAR![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo') → ENFILEIRAR(10) → ENFILEIRAR(11) → ENFILEIRAR(DESENFILEIRAR ![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo')) → ENFILEIRAR(12) → DESENFILEIRAR![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo') → ENFILEIRAR(13) → DESENFILEIRAR![ovo](https://avaead.unisanta.br/theme/image.php/boost/core/1713800366/s/egg 'ovo')

Após realizar as operações acima, a FILA estará no estado

Questão 7Escolha uma opção:[ ] 8 – 9 – 10

[ ] 10 – 11 – 12

[ ] 9 – 10 – 11

[X] 9 – 12 – 13

[ ] 8 – 10 – 11

R:

Vamos analisar cada operação e como ela afeta o estado da fila:

1. ENFILEIRAR(8): Adiciona o número 8 à fila.
   Estado da fila: 8
2. ENFILEIRAR(9): Adiciona o número 9 à fila.
   Estado da fila: 8 - 9
3. DESENFILEIRAR(): Remove o primeiro elemento da fila, que é 8.
   Estado da fila: 9
4. ENFILEIRAR(10): Adiciona o número 10 à fila.
   Estado da fila: 9 - 10
5. ENFILEIRAR(11): Adiciona o número 11 à fila.
   Estado da fila: 9 - 10 - 11
6. ENFILEIRAR(DESENFILEIRAR()): Remove o primeiro elemento da fila, que é 9.
   Estado da fila: 10 - 11
7. ENFILEIRAR(12): Adiciona o número 12 à fila.
   Estado da fila: 10 - 11 - 12
8. DESENFILEIRAR(): Remove o primeiro elemento da fila, que é 10.
   Estado da fila: 11 - 12
9. ENFILEIRAR(13): Adiciona o número 13 à fila.
   Estado da fila: 11 - 12 - 13
10. DESENFILEIRAR(): Remove o primeiro elemento da fila, que é 11.
    Estado da fila: 12 - 13

Portanto, após todas as operações, o estado da fila é 12 - 13. Cada número representa o cliente na ordem em que foram atendidos, onde o 12 foi o primeiro a ser atendido e o 13 foi o último a entrar na fila e será o próximo a ser atendido.

---

(Questão retirada de Prova Enade) A pilha é uma estrutura de dados que permite a inserção/ remoção de itens dinamicamente seguindo a norma de último a entrar, primeiro a sair.

Suponha que para uma estrutura de dados, tipo pilha, são definidos os comandos:

• PUSH (p, n): Empilha um número “n” em uma estrutura de dados do tipo pilha “p”;

• POP (p): Desempilha o elemento no topo da pilha.

Considere que, em uma estrutura de dados tipo pilha “p”, inicialmente vazia, sejam executados os seguintes comandos:

PUSH (p, 10)

PUSH (p, 5)

PUSH (p, 3)

PUSH (p, 40)

POP (p)

PUSH (p, 11)

PUSH (p, 4)

PUSH (p, 7)

POP (p)

POP (p)

Após a execução dos comandos, o elemento no topo da pilha “p” e a soma dos elementos armazenados na pilha “p” são, respectivamente,

Questão 8Escolha uma opção:[ ] 7 e 40

[ ] 7 e 29

[ ] 11 e 80

[ ] 4 e 80

[X] 11 e 29

R:

Vamos percorrer cada comando e analisar seu efeito na pilha "p":

1. PUSH (p, 10): Adiciona o número 10 à pilha.
   Pilha: [10]
2. PUSH (p, 5): Adiciona o número 5 à pilha.
   Pilha: [10, 5]
3. PUSH (p, 3): Adiciona o número 3 à pilha.
   Pilha: [10, 5, 3]
4. PUSH (p, 40): Adiciona o número 40 à pilha.
   Pilha: [10, 5, 3, 40]
5. POP (p): Remove o elemento no topo da pilha, que é 40.
   Pilha: [10, 5, 3]
6. PUSH (p, 11): Adiciona o número 11 à pilha.
   Pilha: [10, 5, 3, 11]
7. PUSH (p, 4): Adiciona o número 4 à pilha.
   Pilha: [10, 5, 3, 11, 4]
8. PUSH (p, 7): Adiciona o número 7 à pilha.
   Pilha: [10, 5, 3, 11, 4, 7]
9. POP (p): Remove o elemento no topo da pilha, que é 7.
   Pilha: [10, 5, 3, 11, 4]
10. POP (p): Remove o elemento no topo da pilha, que é 4.
    Pilha: [10, 5, 3, 11]

Após a execução desses comandos, o elemento no topo da pilha "p" é 11.

A soma dos elementos armazenados na pilha "p" é 10 + 5 + 3 + 11 = 29.

Portanto, a explicação é que o elemento no topo da pilha "p" é 11 e a soma dos elementos armazenados na pilha "p" é 29.

---

(Questão retirada de Prova Enade) Para testar as estruturas PILHA e FILA, um programador realizou a série de operações a seguir, após criar as duas estruturas.

· pilha.push(‘A’); // insere A na Pilha

· pilha.push(‘B’); // insere B na Pilha

· pilha.push(‘C’); // insere C na Pilha

· fila.enqueue(pilha.top()); // insere na Fila o conteúdo do TOPO da Pilha

· fila.enqueue(pilha.top()); // insere na Fila o conteúdo do TOPO da Pilha

· fila.enqueue(‘D’); // insere D na Fila

· pilha.push(fila.dequeue()); // insere na Pilha o conteúdo retirado da Fila

· fila.enqueue(fila.dequeue()); // insere na Fila o conteúdo retirado da própria Fila

· fila.enqueue(pilha.pop()); // insere na Fila o conteúdo retirado da Pilha

· pilha.push(‘E’); // insere E na Pilha

· fila.enqueue(‘E’); // insere E na Fila

· pilha.pop(); // retira dado da Pilha

Após essas operações, ao imprimir o conteúdo de pilha e fila, respectivamente, seria exibido:

Questão 9Escolha uma opção:

[X] pilha: topo → B → A. fila: início → D → B → C → E

[ ] pilha: topo → C → B → A. fila: início → D → C → C → E

[ ] pilha: topo → C → B → A. fila: início → D → B → C → E

[ ] pilha: topo → C → A → E. fila: início → D → A → A → E

[ ] pilha: topo →A. fila: início → D → B → C → E

---

(Questão retirada de Prova Tribunal de Justiça do Estado de Rondônia (TJ-RO) Análise de Sistemas - Desenvolvimento (2021) Considere a lista duplamente encadeada exibida a seguir.

(1, 3, 0, “Verde”) (2, 4, 3, “Azul”) (3, 2, 1, “Amarelo”) (4, 0, 2, “Vermelho”)

Cada elemento pertencente à lista é representado por uma quádrupla, com o seguinte formato: (`<id>`, `<id do anterior>`, `<id do seguinte>`, <conteúdo>).

A ordem do conteúdo dos componentes, segundo a instância da lista apresentada, é:

Questão 10Escolha uma opção:

[ ] Vermelho, Azul, Amarelo, Verde

[X] Verde, Vermelho, Amarelo, Azul ? segunda errada

[ ] Azul, Verde, Vermelho, Amarelo

[ ] Amarelo, Verde, Azul, Vermelho errada

[ ] Vermelho, Amarelo, Azul, Verde

R: Para entender a ordem do conteúdo dos componentes da lista duplamente encadeada apresentada, precisamos analisar cada elemento e como eles estão conectados.

Cada elemento na lista é representado por uma quádrupla com o formato (`<id>`, `<id do anterior>`, `<id do seguinte>`, <conteúdo>), onde:

- O primeiro valor é o ID do elemento atual.
- O segundo valor é o ID do elemento anterior na lista.
- O terceiro valor é o ID do próximo elemento na lista.
- O quarto valor é o conteúdo do elemento.

Vamos analisar os elementos:

1. O primeiro elemento tem o conteúdo "Verde" e o próximo elemento é identificado pelo ID 3.
2. O segundo elemento tem o conteúdo "Azul" e o próximo elemento é identificado pelo ID 4.
3. O terceiro elemento tem o conteúdo "Amarelo" e o próximo elemento é identificado pelo ID 2.
4. O quarto elemento tem o conteúdo "Vermelho" e o próximo elemento é identificado pelo ID 0.

Agora, vamos seguir a ordem dos IDs para determinar a ordem do conteúdo:

- Começamos com o primeiro elemento, que tem o conteúdo "Verde".
- O próximo elemento na lista é o terceiro elemento, que contém "Amarelo".
- Depois, o próximo é o segundo elemento, que contém "Azul".
- Finalmente, o último elemento é o quarto elemento, que contém "Vermelho".

Portanto, a ordem do conteúdo dos componentes da lista, segundo a instância apresentada, é: Verde, Amarelo, Azul, Vermelho.

Espero que isso ajude a entender!

---

(Questão retirada de Prova Enade) No famoso jogo da Torre de Hanoi, é dada uma torre com discos de raios diferentes, empilhados por tamanho decrescente em um dos três pinos dados, como ilustra a figura acima. O objetivo do jogo é transportar-se toda a torre para um dos outros pinos, de acordo com as seguintes regras: apenas um disco pode ser deslocado por vez, e, em todo instante, todos os discos precisam estar em um dos três pinos; além disso, em nenhum momento, um disco pode ser colocado sobre um disco de raio menor que o dele; é claro que o terceiro pino pode ser usado como local temporário para os discos.

Imaginando que se tenha uma situação em que a torre inicial tenha um conjunto de 5 discos, qual o número mínimo de movimentações de discos que deverão ser realizadas para se atingir o objetivo do jogo?

Questão 1Escolha uma opção:

[X] 31

[ ] 38

[ ] 28

[ ] 25

[ ] 34

---

(Questão retirada de Prova 2019 - Câmara Municipal de Taboão da Serra - SP - Analista de Tecnologia da Informação) Uma estrutura de dados do tipo “lista encadeada” com 10 (dez) elementos, sendo que o primeiro e o último estão ligados entre si, recebe o nome de:

Questão 3Escolha uma opção:

[ ] lista moderada

[X] lista encadeada circular

[ ] lista invertida

[ ] lista tríplice

[ ] lista de Zargov

---

(Questão retirada de Prova 2019-Câmara Municipal de Taboão da Serra - SP • Analista de TI) Levando em consideração a estrutura de dados do tipo “Pilha”, analise os itens a seguir e, ao final, assinale a alternativa correta:

I – Um elemento a ser removido é o que está há menos tempo na estrutura de dados.

II – Um elemento a ser removido é o que está há mais tempo na estrutura de dados.

III – Um elemento a ser inserido é colocado na base da pilha.

Questão 5Escolha uma opção:

[ ] Todos os itens são verdadeiros

[ ] Apenas o item III é verdadeiro

[ ] Apenas o item II e III são verdadeiros

[ ] Apenas o item I é verdadeiro

[X] Apenas o item II é verdadeiro errada

---

(Questão retirada de Prova 2018 - SUSIPE-PA - Técnico em Gestão de Infraestrutura - Técnico em Gestão de Informática) Várias estruturas de dados podem ser utilizadas para armazenar dados de uma aplicação. Em relação ao assunto, assinale a alternativa correta.

Questão 10Escolha uma opção:

[ ] Uma estrutura de dados do tipo lista utiliza a ideia do primeiro a chegar, primeiro a ser servido para inserir elementos

[ ] Uma estrutura de dados do tipo fila sempre retira os elementos que entraram por último na fila

[X] Uma estrutura de dados do tipo fila utiliza a ideia do primeiro a chegar, primeiro a ser servido errada

[ ] Uma estrutura de dados do tipo pilha sempre retira os elementos que foram inseridos primeiro na estrutura

[ ] Em uma estrutura de dados do tipo pilha, para retirar o elemento do topo da pilha, é necessário retirar o elemento base da pilha
