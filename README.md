# LogicaCsharp4

RESOLUÇÃO DOS EXERCICIOS DO CURSO: https://github.com/acenelio/curso-logica-de-programacao-csharp

Vetores - Algumas anotações sobre o curso em lógica de programação em Csharp

Um vetor corresponde a uma coleção de dados de tamanho fixo, indexada, unidimensional e homogênea

- Indexada: os elementos são acessados por meio de índices (numeração de cada elemento) 0, 1, 2, 3, 4 | Maria, João, Carlos, Ana, Joaquim
- Unidimensional: Uma dimensão 
- Homogênea: todos dados são do mesmo tipo

- Vetores também são chamados de arranjos unidimensionais
- Em C# a primeira posição de um vetor é a posição 0
- Um arranjo deve ser alocado previamente, antes de ser utilizado; Uma vez alocado, sua quantidade de elementos é fixa.

Como criar um vetor?
Etapa 1: Declaração: int[] a , double[] b; string[] c -> Primeiro declara o tipo, abre e fecha colchetes, e o nome da variável VETOR.
Etapa 2: Instanciação: A = new int[10], B = new double[5], C = new string[8] -> Instancia quantas posições o vetor vai ter.

Como acessar os elementos de um vetor? : A[3] = 10; -> acessando o elemento 3 do VETOR A de valor 10.
EXEMPLO:

for (int i=0; i<5; i++) {
	B[i] = i + 10;
}

CAUSANDO ESSE EFEITO:
POSIÇÕES: 0 | 1 | 2 | 3 | 4 -> VETOR DE NOME B
VALORES: 10 | 11| 12| 13| 14

EXEMPLO:

C[1] = "Maria" -> No vetor C, posição 1 recebe Maria
POSIÇÕES: 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10-> VETOR DE NOME C
VALORES:    |maria|

- Sintaxe opcional foreach
Se aplica para coleções
