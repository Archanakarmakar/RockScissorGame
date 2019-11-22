using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    public class Computer : Player
    {
       public Random rnd = new Random();
        public Computer()
        {
           
        }
        public override void ChooseName()
        {
            this.name ="Computer";
        }
        public  override void ChooseGesture()
        {
            int n = rnd.Next(0, 4);
            Console.WriteLine("Computer choose this gesture ->:" + gestures[n]);
            gesture = gestures[n];
        }
    }
}
