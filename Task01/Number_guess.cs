using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Number_guess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");

            int minNumber = 1;
            int maxNumber = 10;
            int correctAns = 7;
            int targetNumber = new Random().Next(minNumber, maxNumber + 1);


            int maxAttempts = 5;
            int attempts = 0;

            Console.WriteLine($"Guess a number between {minNumber = 1} and {maxNumber = 10}.");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    if (targetNumber == correctAns)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number!");
                        break;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine($"You've reached the maximum number of attempts. The target number was {targetNumber}.");
            }

            Console.WriteLine("Thank you for playing the Number Guessing Game!");
            Console.ReadLine();
        }
    }
}


