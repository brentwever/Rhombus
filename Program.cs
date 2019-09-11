using System;

namespace Exam
{
    class Rhombus
    {
        static void Main()
        {
            Console.WriteLine("Geef de breedte op van een Rhombus die ik voor u ga maken: ");
            var size = Console.ReadLine();
            int number = int.Parse(size);


            // dit is oplopende
            for (int i = 0; i < (number); i++)
            {
                if ((number - i) % 2 != 0)
                {
                    int numberOfSpaces = (number - i) / 2;
                    for (int a = 0; a < numberOfSpaces; a++)
                    {
                        Console.Write(" ");

                    }
                }

                for (int j = 0; j <= i; j++)
                {
                    if ((number - i) % 2 != 0)
                    {
                        Console.Write("#");
                    }

                }
                if ((number - i) % 2 != 0)
                {
                    int numberOfSpaces = (number - i) / 2;
                    for (int a = 0; a < numberOfSpaces; a++)
                    {
                        Console.Write(" ");

                    }
                }



                if ((number - i) % 2 != 0)
                {
                    Console.WriteLine();
                }
            }


            // dit is aflopende
            for (int x = (number - 2); x >= 0; x--)
            {
                if ((number - x) % 2 != 0)
                {
                    int numberOfSpaces = (number - x) / 2;
                    for (int a = 0; a < numberOfSpaces; a++)
                    {
                        Console.Write(" ");

                    }
                }
                for (int y = 0; y <= x; y++)
                {
                    if ((number - x) % 2 != 0)
                    {
                        Console.Write("#");
                    }


                }

                if ((number - x) % 2 != 0)
                {
                    int numberOfSpaces = (number - x) / 2;
                    for (int a = 0; a < numberOfSpaces; a++)
                    {
                        Console.Write(" ");

                    }
                }
                if ((number - x) % 2 != 0)
                {
                    Console.WriteLine();
                }
            }



        }
    }
}