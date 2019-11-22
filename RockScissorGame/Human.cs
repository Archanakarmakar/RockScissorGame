using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    public class Human : Player
    {
        public Human()
        {
            this.name = "Human";
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Which gesture you want to choose... ROCK,PAPER,SCISSOR.LIZARD,SPOCK");

            foreach (string gesture in gestures)
            {

                Console.WriteLine(gesture);

            }
            gesture = Console.ReadLine();
            if (gestures.Contains(gesture))
            {
            }
            else
            {
                Console.WriteLine("Please type the correct input  AND  Choose one of these(ROCK,PAPER,SCISSOR.LIZARD,SPOCK)\n\n");
            }
        }
        public override void ChooseName()
        {
            Console.WriteLine("PLEASE Choose a Name OF gesture list..... .");
            name = Console.ReadLine();
           // Console.WriteLine("name of gesture" + name);

        }

    }
}

