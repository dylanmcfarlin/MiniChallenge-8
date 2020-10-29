using System;

// Dylan McFarlin
// Date Revised: 9-8-20
// MiniChallenge#8
// Program has the user select difficulty mode for guessing game and will tell the user to enter a number
// and will decide if the user is too low, too high or if it's correct.
// Code Reviewed by: Adrian S
// Comments: 

namespace MiniChallenge_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Choose difficulty:");
            Console.WriteLine("     For easy, type 'Easy'");
            Console.WriteLine("     For medium, type 'Medium'");
            Console.WriteLine("     For hard, type 'Hard'");
            string userMode = Console.ReadLine();

            bool guessedNum = false;
            int counter = 1;
            if (userMode == "Easy")
            {
                Random random = new Random();
                int generatedNum = random.Next(1, 10);
                Console.WriteLine("Enter a number: (1-10)");
                while (!guessedNum)
                {
                    int userGuess = Int16.Parse(Console.ReadLine());
                    if (userGuess == generatedNum)
                    {
                        Console.WriteLine("Congrats you guessed the number!");
                        Console.WriteLine("It took you " + counter + " tries.");
                        Console.WriteLine();
                        guessedNum = true;
                    }
                    else if (userGuess < generatedNum)
                    {
                        Console.WriteLine("Guess is too low.");
                        counter++;
                    }
                    else if (userGuess > generatedNum)
                    {
                        Console.WriteLine("Guess is too high.");
                        counter++;
                    }
                }
            }
            if (userMode == "Medium")
            {
                Random random = new Random();
                int generatedNum = random.Next(1, 50);
                Console.WriteLine("Enter a number: (1-50)");
                while (!guessedNum)
                {
                    int userGuess = Int16.Parse(Console.ReadLine());
                    if (userGuess == generatedNum)
                    {
                        Console.WriteLine("Congrats you guessed the number!");
                        Console.WriteLine("It took you " + counter + " tries.");
                        Console.WriteLine();
                        guessedNum = true;
                    }
                    else if (userGuess < generatedNum)
                    {
                        Console.WriteLine("Guess is too low.");
                        counter++;
                    }
                    else if (userGuess > generatedNum)
                    {
                        Console.WriteLine("Guess is too high.");
                        counter++;
                    }
                }
            }
            if (userMode == "Hard")
            {
                Random random = new Random();
                int generatedNum = random.Next(1, 50);
                Console.WriteLine("Enter a number: (1-100)");
                while (!guessedNum)
                {
                    int userGuess = Int16.Parse(Console.ReadLine());
                    if (userGuess == generatedNum)
                    {
                        Console.WriteLine("Congrats you guessed the number!");
                        Console.WriteLine("It took you " + counter + " tries.");
                        Console.WriteLine();
                        guessedNum = true;
                    }
                    else if (userGuess < generatedNum)
                    {
                        Console.WriteLine("Guess is too low.");
                        counter++;
                    }
                    else if (userGuess > generatedNum)
                    {
                        Console.WriteLine("Guess is too high.");
                        counter++;
                    }
                }
            } else {
                Console.WriteLine("That is not a valid difficulty mode.");
            }
        }
    }
}
