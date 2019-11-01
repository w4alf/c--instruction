using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roller App");


            // perform invoice calculations until choice isn't equal to "y" or "Y"
            String choice = "y";

            while (!choice.Equals("n"))
            {

               

                Console.Write("Roll the Dice? : ");
                choice = Console.ReadLine();
                choice.ToLower();

                if (choice.Equals("y"))

                Console.Write("Enter Yearly Interest Rate as whole number: ");
                double InterestRate = Convert.ToDouble(Console.ReadLine()) / 100;

                double InterestAmount = LoanAmount * InterestRate;


                // display the discount amount and total
                String message = "Loan Amount: " + LoanAmount.ToString("C2") + "\n"
                               + "Interest Rate:  " + InterestRate.ToString("P2") + "\n"
                               + "Interest:    " + InterestAmount.ToString("C2") + "\n";
                Console.WriteLine(message);

                // see if the user wants to continue

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();



            }

            Console.WriteLine("Thank you, bye bye");

        }
    }
}
