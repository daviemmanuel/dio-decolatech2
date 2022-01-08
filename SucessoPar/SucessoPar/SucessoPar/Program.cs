using System;

class DIO
{

    static void Main(string[] args)
    {


        Console.WriteLine("Digite um valor:  ");
        int x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
        {
            x += 2;
            Console.WriteLine(x);

        }
        else
        {
            x++;
            Console.WriteLine(x);
        }

    }

}