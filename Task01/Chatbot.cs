using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Chatbot
    {
         static void Main(string[] args)
        {
            

            Dictionary<string, string> predefinedResponses = new Dictionary<string, string>()
        {
            {"Hello","Hey!"},
            {"What is your name?", "My name is Chatbot." },
            { "How are you?", "I'm doing well, thank you!,How are you?" },
            { "i am good too,Ok tel me, What is the todays weather?","I dont have access to real-time information." },
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
        

