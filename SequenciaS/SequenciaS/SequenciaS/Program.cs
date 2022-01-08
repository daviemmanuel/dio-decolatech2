using System;

class DIO
{

    static void Main(string[] args)
    {

        double c, S = 0;
        for (double n = 1; n <= 100; n++)
        {
            c = 1 / n;
            S = S + c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);

    }

}