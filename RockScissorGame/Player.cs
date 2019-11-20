using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorGame
{
    public abstract class Player
    {
    public int numberOfWins;
    public string name;
    public int currentSelection;
    public Player()
    {
    numberOfWins = 0;
    }
    public abstract void ChooseGesture();
    }
}
