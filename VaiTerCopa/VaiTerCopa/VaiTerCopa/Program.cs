using System;

class DIO
{

    static void Main(string[] args)
    {

        string str;
        while ((str = Console.ReadLine()) != null)
        {
                int x = int.Parse(str);
                if (x > 0)
                {
                    Console.WriteLine("vai ter duas");
                }
                else
                {
                    Console.WriteLine("Vai ter copa");
                }
            }
        }

    }

