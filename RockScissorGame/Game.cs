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
        public int count = 0;
        public int winnerscore = 2;
        bool gameOver = false;
        Player Player1 = new Human();
        Player Player2 = new Computer();
        public Random rnd = new Random();
        string defeat = "defeats";
        public Game()
        {
        }
        public string GetNumberPlayer()
        {
            Console.WriteLine("\nWelcome To Rock Paper Scissors Lizard Spock Game");

            Console.WriteLine("How many Players to play this Game?: \n  1.)Human \n 2.)computer\n ");//asks the player for their choice
            Numberplayer = Console.ReadLine();

            switch (Numberplayer)
            {

                case "1":
                    Console.WriteLine("Do you want to play Human Vs  Human");
                    break;

                case "2":
                    Console.WriteLine("Do you want to play Human Vs computer ");
                    break;

                default:
                    Console.WriteLine("Quit");
                    break;
            }
            return Numberplayer;
        }
        public void CreatePlayer(String NumberPlayer)
        {
            if (NumberPlayer == "1")
            {
                Player1 = new Human();
                Player2 = new Computer();
            }
            else if (NumberPlayer == "2")
            {
                Player1 = new Human();
                Player2 = new Human();
            }
        }
      /*public bool GetTieGame()
        {
            if ((Player1.gesture == Player1.score || Player2.gesture == Player2.score))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public void GameRun()
        {
            string input = GetNumberPlayer();
            
            CreatePlayer(input);
           
            CompareToPlayers();
            DisplayWinner();


        }
        public void DisplayWinner()
         {
             Console.WriteLine("\n{0} WINS THE GAME!\n"+Player2.name);

         }
        public void CompareToPlayers()
        {
            
            while (!gameOver)
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
                if ((Player1.gesture == "SCISSOR") && (Player2.gesture == "PAPER"))
                    {
                        Player1.score++;
                        Console.WriteLine("Winner is " + Player1.gesture);
                        Console.WriteLine( "Looser is"+Player2.gesture);
                        defeat = "cuts";
                        count += 1;
                    }
                    else if ((Player1.gesture == "PAPER") && (Player2.gesture == "ROCK"))
                    {
                        Player1.score++;
                        Console.WriteLine("Winner is " + Player1.gesture);
                        Console.WriteLine("Looser is" + Player2.gesture);
                        defeat = "covers";
                        count += 1;
                    }
                    else if ((Player1.gesture == "ROCK") && (Player2.gesture == "LIZARD"))
                    {
                       Player1.score++;
                       Console.WriteLine("Winner is " + Player1.gesture);
                       Console.WriteLine("Looser is" + Player2.gesture);
                       defeat = "crushes";
                        count += 1;
                    }
                    else if ((Player1.gesture == "LIZARD") && (Player2.gesture == "SPOCK"))
                    {
                        Player1.score++;
                        Console.WriteLine("Winner is " + Player1.gesture);
                        Console.WriteLine("Looser is" + Player2.gesture);
                        defeat = "poisons";
                        count += 1;
                    }
                    else if ((Player1.gesture == "SPOCK") && (Player2.gesture == "SCISSOR"))
                    {
                       Player1.score++;
                       Console.WriteLine("Winner is " + Player1.gesture);
                       Console.WriteLine("Looser is" + Player2.gesture);
                       defeat = "smashes";
                       count += 1;
                    }
                    else if ((Player1.gesture == "SCISSOR") && (Player2.gesture == "LIZARD"))
                    {
                        Player1.score++;
                        Console.WriteLine("Winner is " + Player1.gesture);
                        Console.WriteLine("Looser is" + Player2.gesture);
                        defeat = "decapitates";
                        count += 1;
                    }
                    else if ((Player1.gesture == "LIZARD") && (Player2.gesture == "PAPER"))
                    {
                      Player1.score++;
                    Console.WriteLine("Winner is " + Player1.gesture);
                    Console.WriteLine("Looser is" + Player2.gesture);
                    defeat = "eats";
                        count += 1;
                    }
                    else if ((Player1.gesture == "PAPER") && (Player2.gesture == "SPOCK"))
                    {
                      Player1.score++;
                    Console.WriteLine("Winner is " + Player1.gesture);
                    Console.WriteLine("Looser is" + Player2.gesture);
                    defeat = "disproves";
                        count += 1;
                    }
                    else if ((Player1.gesture == "SPOCK") && (Player2.gesture == "ROCK"))
                    {
                      Player1.score++;
                    Console.WriteLine("Winner is " + Player1.gesture);
                    Console.WriteLine("Looser is" + Player2.gesture);
                     defeat = "vaporizes";
                         count += 1;
                    }
                    else if ((Player1.gesture == "ROCK") && (Player2.gesture == "SCISSOR"))
                    { 
                                  
                     Player1.score++;
                     Console.WriteLine("Winner is " + Player1.gesture);
                     Console.WriteLine("Looser is" + Player2.gesture);
                      defeat = "blunts";
                       count += 1;
                    }
                    else if(Player1.gesture == Player2.gesture)
                    {
                    Console.WriteLine("Tie game");
                    }
                    else
                    {
                     
                    }
            }

                Console.WriteLine("Do u want to continue(YES/NO):");
            }
        }
    }



