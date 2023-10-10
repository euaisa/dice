using System;

namespace DiceGameCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMonth;

            do
            {
                // Ask the user for the month they were born in
                Console.Write("Enter your birth month (1-12): ");

                if (int.TryParse(Console.ReadLine(), out userMonth) && userMonth >= 1 && userMonth <= 12)
                {
                    // Check which season they were born in
                    if (userMonth == 12 || userMonth == 1 || userMonth == 2)
                    {
                        Console.WriteLine("You were born in Winter");
                    }
                    else if (userMonth >= 3 && userMonth <= 5)
                    {
                        Console.WriteLine("You were born in Spring");
                    }
                    else if (userMonth >= 6 && userMonth <= 8)
                    {
                        Console.WriteLine("You were born in Summer");
                    }
                    else if (userMonth >= 9 && userMonth <= 11)
                    {
                        Console.WriteLine("You were born in Fall");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number between 1 and 12.");
                }

            } while (userMonth < 1 || userMonth > 12);
        }
    }
}
