using System;
using System.Globalization;

namespace QuartoProjeto
{
    public class Program
    {
        static void Main (string[] args)
        {
            /*
            // Problema exemplo
            Fazer um programa para ler um número inteiro positivo N, depois ler N números quaisquer e armazená-lis em um vetor. Em seguinda,
            mostrar na tela todos elementos do vetor.
           
            int N;
            double[] vet; // Declarando tipo de vetor, double de nome vet

            N = int.Parse(Console.ReadLine());
            vet = new double[N]; // Instancia novo tipo de vetor e quantas posições/indices vai ter. Ou seja, se voce digitar, 4, será aberto quatro possições

            for (int i=0; i<N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i=0; i<N;i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture)); 
            }
             */

            /*
            // Problema exemplo 2
            Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos
            lidos
            

            Console.WriteLine("Informe uma quantidade que você quer de números inteiros: ");

            int N;
            int[] vetor;

            N = int.Parse(Console.ReadLine());
            vetor = new int[N]; // alocação das posições na memoria, faz vetor receber int N elementos

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i<N; i++)
            {
                vetor[i] = int.Parse(s[i]); // vetor i recebe o vetor s na posição i, convertido para inteiro
            }

            for (int i = 0; i<N; i++) // para percorrer o vetor e imprimir apenas os elementos que forem negativos
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            */

            /*
            // Problema exemplo 3
            //Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida:
            - Imprimir todos os elementos do vetor
            - Mostrar na tela a soma e a média dos elementos do vetor

            
            int N;
            double[] numerosReais;

            N = int.Parse(Console.ReadLine());
            numerosReais = new double[N];

            Console.WriteLine("Informe os números reais: ");
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numerosReais[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i=0; i<N; i++)
            {
                Console.Write(numerosReais[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int i=0; i<N; i++)
            {
                soma = soma + numerosReais[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */

            /*
            // Sintaxe opcional foreach - Problema exemplo
            Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes lidos.

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            for (int i = 0; i < N; i++) { // INICIA COM A PRIMEIRA POSIÇÃO DA COLEÇÃO
                Console.WriteLine(vet[i]);
            }
            Console.ReadLine();

            ou COM FOR EACH:

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string elemento in vet) { // PARA CADA ELEMENTO NO VETOR VET
                Console.WriteLine(elemento);
            }
            Console.ReadLine();

            */

            // Exercicios de vetores para fazer: estao no drive pessoal do google em "programação"



        }
    }
}