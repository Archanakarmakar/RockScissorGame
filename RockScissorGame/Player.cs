using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
   public abstract class Player
    {
    public List<string> gestures = new List<string>() { "ROCK", "PAPER", "SCISSOR", "LIZARD", "SPOCK" };
    public string name;
    public int score;
   public string gesture;
   
    public abstract void ChooseGesture();
    public abstract void ChooseName();
    }
}
