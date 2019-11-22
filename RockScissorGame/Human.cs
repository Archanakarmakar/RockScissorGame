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
            Console.WriteLine("Which gesture you want to choose...");
           
            foreach (string gesture in gestures)
            {

             Console.WriteLine(gesture);
            
            }

            gesture = Console.ReadLine();
        }
      public override void ChooseName()
        {
         Console.WriteLine("Choose a Name....");
            name = Console.ReadLine();
           
        }
    }
}
