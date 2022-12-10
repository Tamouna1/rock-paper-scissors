using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            String player;
            String computer;
            bool playAgain = true;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
                    Console.WriteLine("Enter rock, paper or scissors");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }
                int randomNum;
                switch (random.Next(1, 4)) { 
                    
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                    break;
                
                
                }

                Console.WriteLine("PLAYER: " + player);
                Console.WriteLine("COMPUTER: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK") {
                            Console.WriteLine("It's a draw!");
                       }else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw1");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        break;

                        Console.Write("Would you like to play again (Y/N): ");
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


            }

        }
        }
}


