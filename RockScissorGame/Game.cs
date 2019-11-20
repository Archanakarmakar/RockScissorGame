using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    class Game:Player
    {

        public string HumanPlayer;
        public string ComputerPlayers;
        public string ans = "";
        public int count = 0;
        public int count1 = 0;
         Game()
        {

        }
        public  override void ChooseGesture()
        {
         Console.WriteLine("\nWelcome To Rock Paper Scissors Game");
         string testString;
         Console.WriteLine("Enter your choice: \n  1.)Rock \n 2.)Paper\n  3.)Scissors\n 4.Lizard \n 5.Spock");//asks the player for their choice
         testString = Console.ReadLine();
         Console.WriteLine("You entered {0}", testString);
         string[] choices = new string[5] { "ROCK", "PAPER", "SCISSOR","LIZARD","SPOCK"};
         Random rnd = new Random();
         int n = rnd.Next(0, 5);

        }
    }
}
