//Xenlongão

using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao

    // Resolvendo de maneira um pouco diferente  o problema, utilizando a raiz quadrada.
    {
        static void Main(string[] args)
        {
            var testes = int.Parse(Console.ReadLine());

            for (int i = 0; i < testes; i++)
            {
                var esferas = int.Parse(Console.ReadLine());

                Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
            }
        }
    }
}