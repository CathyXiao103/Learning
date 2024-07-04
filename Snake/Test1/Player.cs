using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class Player
    { 
        public int Position { get; set; }
        public string Name { get; set; }

        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
