using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    public class Computer : Player
    {
        public Random randomNumber = new Random();
        public Computer()
        {
            this.name = "ComputerPlayer";
        }
        public  override void ChooseGesture()
        {
        }
    }
}
