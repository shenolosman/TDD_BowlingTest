using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        private int[] rolls=new int[21];
        private int currentRoll = 0;
        public void Roll(int pins)
        {
           // _score += pins;
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int _score = 0;
            int i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[i]+rolls[i+1]==10)//spare
                {
                    _score += 10 + rolls[i + 2];
                    i += 2;
                }else {
                    _score += rolls[i] + rolls[i + 1];
                    i += 2;
                }
            }
            return _score;
        }
    }
}
