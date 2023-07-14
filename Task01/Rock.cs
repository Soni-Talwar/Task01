using System;

namespace Task01
{
    class Rock
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string Player;
            string Computer;
            string answer;

            while (playAgain)
            {
                Player = "";
                Computer = "";
                answer = "";

                while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS")
                {
                    Console.Write("Enter ROCK,PAPER or SCISSORS:");
                    Player = Console.ReadLine();
                    Player = Player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        Computer = "ROCK";
                        break;
                    case 2:
                        Computer = "PAPER";
                        break;
                    case 3:
                        Computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player:" + Player);
                Console.WriteLine("Computer:" + Computer);

                switch (Player)
                {
                    case "ROCK":
                        if (Computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (Computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win :)");
                        }
                        break;
                    case "PAPER":
                        if (Computer == "ROCK")
                        {
                            Console.WriteLine("You win :)");
                        }
                        else if (Computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose :(");
                        }
                        break;
                    case "SCISSORS":
                        if (Computer == "ROCK")
                        {
                            Console.WriteLine("You lose :(");
                        }
                        else if (Computer == "PAPER")
                        {
                            Console.WriteLine("You Win :)");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N):");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("!!Thanks for playing !! :)");

            Console.ReadKey();
        }
    }
}
