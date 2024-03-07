namespace Quest02_Q07
{
    internal class Program{
        static void Main(string[] args){
            float nf, resFloat;
            Console.wtite("Fornaça o preço: ");
            nf = float.Parse(Console.ReadLine());

            resFloat = nf * 10.5;

            Console.WriteLine("O preço {0:C} e o novo {1:C}", nf, resFloat);

            Console.ReadKey();
        }
    }
}
//Linha 17 nf = float.Parse(Console.ReadLine()F);




namespace Quest02_Q004
{
    internal class Program {
        static void main(string[] args) {
            char c1;
            string c2;
            string c3, c4;

            c1 = "C";
            c2 = "certo";
            c3 = "13";
            c4 = "91112345"

            Console.WriteLine("O valor de c1 é : " + c1);
            Console.WriteLine("O valor de c2 é : " + c2);
            Console.WriteLine("O valor de c3 concatenado com c4 é : " + c3 + c4);

            Console.ReadKey();
        }
    }
}
//Não Irá funcionar pois existe um erro na atribuição de valores.




namespace Quest02_Q08

{
    internal class Program {
                static void main(string[] args) {
                    int a, b = 2;

                    a = 5

                    Console.WriteLine("O resultado é: " +a%b);

                    Console.ReadKey();
                }
    }
}
//O Resultado é 1


//----------------------------
A linha de comando abaixo:

Byte n1 = 10, n2 = 20;
Questão 4Escolha uma opção:

Está correta, mas fará com que o valor de n1 também fique igual a 20.


Está errada porque após o 10 deveria aparecer um ponto e vírgula ao invés de uma vírgula.


Está errada porque não é possível declarar e atribuir valores a mais de uma variável simultaneamente.


Está correta.

//Está correta.

//--------------------------------

Assinale a alternativa que completa a frase abaixo

O comando Console.Read recebe valores como _____ e Console.ReadLine recebe valores como _____
Questão 5Escolha uma opção:

Int ---- String


String ----- Int


String ----- Char


Char ----- String

//O comando Console.Read recebe valores como int e o comando Console.ReadLine recebe valores como string.


//--------------------------------


Relacione as explicações com o tipo de variável:

Recebe somente números inteiros positivos

Resposta 1 Questão 1
Variável do tipo byte
Valores atribuídos devem estar entre aspas duplas

Resposta 2 Questão 1
Variável do tipo string
Valores atribuídos devem estar entre aspas simples

Resposta 3 Questão 1
Variável do tipo char
Recebe somente dois valores True ou False

Resposta 4 Questão 1
Variável do tipo bool


//--------------------------------

using System;

namespace Quest02_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f1;
            float f2 = 60.229f; // Correção: adição do sufixo 'f' para indicar float

            f1 = 50.1249f; // Correção: adição do sufixo 'f' para indicar float

            Console.WriteLine("O valor de f1 é : {0:F2}", f1);
            Console.WriteLine("O valor de f2 é : {0:F2}", f2);

            Console.ReadKey();
        }
    }
}
//Nas declarações de f2 e f1 falta o sufixo F.


//--------------------------------

using System;

namespace Quest02_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a1, a2, a3;
           bool t1, t2;

           Console.Write("Forneça o primeiro valor: ");
           t1 = double.TryParse(Console.ReadLine(), out a1);
           Console.Write("Forneça o segundo valor: ");
           t2 = double.TryParse(Console.ReadLine(), out a2);   
           a3 = 2*a1+a2/2
           Console.WriteLine(" A resposta é {0}", a3);

           Console.ReadKey();
        }
    }
}
//false, false, A e 10

//--------------------------------

using System;

namespace Quest02_Q09
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a1, a2, a3;
           bool t1, t2;

           Console.Write("Forneça o primeiro valor: ");
              t1 = double.TryParse(Console.ReadLine(), out a1);
              Console.Write("Forneça o segundo valor: ");
                t2 = double.TryParse(Console.ReadLine(), out a2);
                a3 = 2*a1+a2/2;
                Console.WriteLine(" A resposta é {0}", a3);

                Console.ReadKey();

        }
    }
}
//false, true, A e 10

O programador executou o programa, fornecendo para primeiro valor 10 e para segundo valor A.

A resposta que ele obteve foi:
//20

//--------------------------------


using System;

namespace Quest02_Q09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char valor;

            Console.Write("Forneça um valor: ");
            valor =  Console.Read();

            Console.WriteLine("O código do caractér é: " + valor);

            Console.ReadKey();
        }
    }
}
//Acrescentar na linha 21 }

//--------------------------------

using System;

namespace Quest02_Q06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracao de variavel
            char valor;
            //recebe valor
            Console.Write("Forneça um valor: ");
            valor =  Console.Read();

            Console.WriteLine("O código do caractér é: " + valor);
//mantem a tela aguardando digitação 
            Console.ReadKey();
        }
    }
}

//--------------------------------

using System;

namespace Quest02_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            char c1
            String c2
            String c3, c4;

            //atribuicao
            c1 = "C";
            c2 = "certo";
            c3 = "13";
            c4 = "91112345"

            //impressao
            Console.WriteLine("O valor de c1 é : " + c1);
            Console.WriteLine("O valor de c2 é : " + c2);
            Console.WriteLine("O valor de c3 concatenado com c4 é : " + c3 + c4);

            //mantem a tela aguardando digitação
            Console.ReadKey();
        }
    }
}

// Não Irá funcionar pois existe um erro na atribuição de valores.

//--------------------------------