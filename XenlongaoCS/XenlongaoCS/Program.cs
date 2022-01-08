//Xenlongão

using System;
using System.Collections.Generic;
using System.Text;

//A questão pede que sejam excluídos os números
// Que têm número par de divisores;
//Podemos achar a quantidade de divisores de um números
// Com a decomposição em fatores primos;
//Podemos encontrar a quantidade de divisores pares
// com uma técnica de soma e multiplicação dos expoentes dos
// Fatores. Mais informações procurar por https://www.youtube.com/watch?v=MG7qFGnkqgw;
// Um número é par quando todos os expoentes são ímpares.
// Um número é ímpar quando o resultado da decomposição é par.
// Então esse número precisa ser um quadrado perfeito Para
// Que o número de divisores seja par.
// No final das contas, devemos excluir todos os números
// Que são quadrados perfeitos pois
// são estes que tem divisores ímpares como vemos na imagem das bolas.
// A quantidade de números que são
// Quadrados pefeitos em um intervalo [1...N] é exatamente
// a raiz quadrada de N;

namespace Dio
{
    class Xenlongao

    // Resolvendo de maneira um pouco diferente  o problema, utilizando a raiz quadrada.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de casos de teste:");
            var testes = int.Parse(Console.ReadLine());


            Console.WriteLine("Quantidade de esferas: (2<=N<109)");
            for (int i = 0; i < testes; i++)
            {
                var esferas = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultado:");
                Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
            }
        }
    }
}