using System;

class DIO
{

    static void Main(string[] args)
    {



        for (int i = 1; i <= 9; i += 2)
        {
            for (int w = 0, j = 7; w < 3; ++w, j--)   
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }

}