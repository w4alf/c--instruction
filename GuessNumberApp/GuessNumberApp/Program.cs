using System;

namespace GuessNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void displayWelcome(int limit)
            {
                Console.WriteLine("Guess the number!");
                Console.WriteLine("I'm thinking of a number from 1 to " + limit);
                Console.WriteLine();
            }

            int getRandomInt(int limit)
            {
                Random random = new Random();
                int r2 = random.Next(limit);
                r2++;
                
                // int is >= 1 and <= limit
                return r2;
            }





            Console.WriteLine("Hello World!");
        }
    }
}
