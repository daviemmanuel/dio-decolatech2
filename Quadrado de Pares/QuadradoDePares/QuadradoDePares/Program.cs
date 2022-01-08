using System;

class DIO
{

    static void Main(string[] args)
    {


        //Pedindo input de um número 
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {

            int b = i;
            int resultado = (i*b);
            Console.WriteLine($"{i}^2 = {resultado}");
        }

    }

}