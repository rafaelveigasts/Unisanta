//EXERCÍCIO 3.2.5-AInserir a sequência de números abaixo em uma Árvore Binária, deixando-a em ordem crescente.32 / 98 / 90 / 75 / 30 / 24 / 10 / 15 / 88 / 17 / 95 / 12 / 72 / 47 / 38 /48 / 40 / 45 / 42 / 77 / 73 / 46 / 80 / 78 / 27 / 51 / 69 / 60 / 55 / 28.

const arvore = [
  32, 98, 90, 75, 30, 24, 10, 15, 88, 17, 95, 12, 72, 47, 38, 48, 40, 45, 42,
  77, 73, 46, 80, 78, 27, 51, 69, 60, 55, 28,
]

class No {
  valor: number
  esquerda: No | null
  direita: No | null

  constructor(valor: number) {
    this.valor = valor
    this.esquerda = null
    this.direita = null
  }
}

class Arvore {
  raiz: No | null

  constructor() {
    this.raiz = null
  }

  inserir(valor: number) {
    const novoNo = new No(valor)

    if (!this.raiz) {
      this.raiz = novoNo
    } else {
      this.inserirNo(this.raiz, novoNo)
    }
  }

  inserirNo(raiz: No, novoNo: No) {
    if (novoNo.valor < raiz.valor) {
      if (!raiz.esquerda) {
        raiz.esquerda = novoNo
      } else {
        this.inserirNo(raiz.esquerda, novoNo)
      }
    } else {
      if (!raiz.direita) {
        raiz.direita = novoNo
      } else {
        this.inserirNo(raiz.direita, novoNo)
      }
    }
  }

  emOrdem(raiz: No | null) {
    if (raiz) {
      this.emOrdem(raiz.esquerda)
      console.log(raiz.valor)
      this.emOrdem(raiz.direita)
    }
  }
}

const arvoreBinaria = new Arvore()

arvore.forEach((valor) => arvoreBinaria.inserir(valor))

arvoreBinaria.emOrdem(arvoreBinaria.raiz)

//EXERCÍCIO 3.2.5-BPreencher os nós da árvore abaixo com os númerosde 1 a 28 mantendo a ordem crescente.
