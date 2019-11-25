using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    public class Game
    {
        string Numberplayer;
        public int winnerscore = 2;
        Player Player1 = new Human();
        Player Player2 = new Computer();
        public Random rnd = new Random();
        string defeat = "defeats";
        public Game()
        {
        }
        public string GetNumberPlayer()
        {
            Console.WriteLine("Which players to play this Game?: \n  1).Human \n 2).Computer \n 3).Play Again \n 4).Quit");//asks the player for their choice
            Numberplayer = Console.ReadLine();

            switch (Numberplayer)
            {

                case "1":
                    Console.WriteLine("You are playing with Human Vs  Human\n\n");
                    break;
                case "2":
                    Console.WriteLine("You are playing with Human Vs computer\n\n ");
                    break;
                case "3":
                    Console.WriteLine("Do you want to play again\n\n ");
                    GetNumberPlayer();
                    GameRun();
                    break;
                case "4":
                    Console.WriteLine("Quit\n\n ");
                    break;

                default:
                    Console.WriteLine("*****************************************************************\n");
                    break;
            }
            Console.ReadLine();
            return Numberplayer;

        }
        public void CreatePlayer(String NumberPlayer)
        {
            if (NumberPlayer == "1")
            {
                Player1 = new Human();
                Player2 = new Human();
            }
            else if (NumberPlayer == "2")
            {
                Player1 = new Human();
                Player2 = new Computer();
            }
        }

        public void GameRun()
        {
            Console.WriteLine("Welcome To Rock Paper Scissors Lizard Spock Game");
            Console.WriteLine("**************************************************************************************\n");
            Console.WriteLine("\nRules:........");
            Console.WriteLine("This game is an expansion on the game Rock, Paper,Scissors,Lizard,Spock.....,During each round,each Human player plays with Human player\n either Human player plays with Computer player");
            Console.WriteLine("\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\nRock blunts Scissors");
            Console.WriteLine("**************************************************************************************\n");
            string input = GetNumberPlayer();

            CreatePlayer(input);
            CompareToPlayers();
            DetermineGameWinner();
            DisplayWinner();


        }
        public void DisplayWinner()
        {
            Console.WriteLine("\nTHE GAME ENDS......");
            Console.ReadLine();

        }
        public void CompareToPlayers()
        {

            while (Player1.score <  2 && Player2.score < 2 )
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
                if (((Player1.gesture == "SCISSOR") && (Player2.gesture == "PAPER")) || ((Player1.gesture == "PAPER") && (Player2.gesture == "SCISSOR")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ......... " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "cuts";
                    
                }
                else if (((Player1.gesture == "PAPER") && (Player2.gesture == "ROCK"))||((Player1.gesture == "ROCK") && (Player2.gesture == "PAPER")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ....... " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "covers";
                            
                }
                else if (((Player1.gesture == "ROCK") && (Player2.gesture == "LIZARD"))|| ((Player1.gesture == "LIZARD") && (Player2.gesture == "ROCK")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is....... " + Player1.gesture);
                    Console.WriteLine("\nLooser is......." + Player2.gesture);
                    defeat = "crushes";
                }
                else if (((Player1.gesture == "LIZARD") && (Player2.gesture == "SPOCK"))|| ((Player1.gesture == "SPOCK") && (Player2.gesture == "LIZARD")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is...... " + Player1.gesture);
                    Console.WriteLine("\nLooser is......" + Player2.gesture);
                    defeat = "poisons";
                }
                else if (((Player1.gesture == "SPOCK") && (Player2.gesture == "SCISSOR"))|| ((Player1.gesture == "SCISSOR") && (Player2.gesture == "SPOCK")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ...... " + Player1.gesture);
                    Console.WriteLine("\nLooser is......." + Player2.gesture);
                    defeat = "smashes";
                }
                else if (((Player1.gesture == "SCISSOR") && (Player2.gesture == "LIZARD")) || ((Player1.gesture == "LIZARD") && (Player2.gesture == "SCISSOR")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ....." + Player1.gesture);
                    Console.WriteLine("\nLooser is......" + Player2.gesture);
                    defeat = "decapitates";
                }
                else if (((Player1.gesture == "LIZARD") && (Player2.gesture == "PAPER")) || ((Player1.gesture == "PAPER") && (Player2.gesture == "LIZARD")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is........ " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "eats";

                }
                else if (((Player1.gesture == "PAPER") && (Player2.gesture == "SPOCK"))|| ((Player1.gesture == "SPOCK") && (Player2.gesture == "PAPER")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ....... " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "disproves";

                }
                else if (((Player1.gesture == "SPOCK") && (Player2.gesture == "ROCK")) || ((Player1.gesture == "ROCK") && (Player2.gesture == "SPOCK")))
                {
                    Player1.score++;
                    Console.WriteLine("\nWinner is ....... " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "vaporizes";

                }
                else if (((Player1.gesture == "ROCK") && (Player2.gesture == "SCISSOR"))|| ((Player1.gesture == "SCISSOR") && (Player2.gesture == "ROCK")))
                {

                    Player1.score++;
                    Console.WriteLine("\nWinner is........ " + Player1.gesture);
                    Console.WriteLine("\nLooser is........" + Player2.gesture);
                    defeat = "blunts";

                }
                else if (Player1.gesture == Player2.gesture)
                {
                    Console.WriteLine("\n\nTie game to player1 and player2");
                }
                else
                {
                    //Console.WriteLine("Do you want to Quitpress number 4 either play again to press number 3...");
                    Console.ReadLine();
                    Player2.score++;
                }
            }

        }
        public void DetermineGameWinner()
        {
            if (Player2.score == 2)
            {
                Console.WriteLine("This guy is Final player2........" + Player2.score);
               
            }
            else if (Player1.score == 2)
            {
                Console.WriteLine("This guy is Final player1....." + Player1.score);
               
            }
            else
            {
                Console.WriteLine("Do you want to Quit press number 4 either play again to press number 3....");
            }
        }
    }
}




