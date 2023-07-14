using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Words
    {

        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 100;
            int numberOfAttempts = 5;

            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber + 1);

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine($"I'm thinking of a number between {minNumber} and {maxNumber}.");
            Console.WriteLine("Can you guess it within a certain number of attempts?");
            Console.WriteLine();

            int attempts = 0;
            int guess;

            while (attempts < numberOfAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
            }

            Console.WriteLine($"Game over! You exceeded the number of attempts. The correct number was {randomNumber}.");
        }


        static void MyChatbot()
        {


            Dictionary<string, string> predefinedResponses = new Dictionary<string, string>()
        {
            {"Hello","Hey!"},
            {"What is your name?", "My name is Chatbot." },
            { "How are you?", "I'm doing well, thank you!,How are you?" },
            { "i am good too,Ok tel me, What is the todays weather?", "I don't have access to real-time information." },
            { "Who created you?", "I was created by OpenAI." }
        };

            string userResponse;

            while (true)
            {
                Console.Write("Ask me a question: ");
                userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "exit")
                    break;

                if (predefinedResponses.ContainsKey(userResponse))
                {
                    Console.WriteLine(predefinedResponses[userResponse]);
                }
                else
                {
                    Console.WriteLine("I don't understand your question.");
                }
            }

            Console.WriteLine("Goodbye! Have a nice day.");

        }


    }

}

