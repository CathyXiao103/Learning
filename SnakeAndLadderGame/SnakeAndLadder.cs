﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class SnakeAndLadder
    {
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
