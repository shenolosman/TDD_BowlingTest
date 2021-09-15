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
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int _score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex]==10)
                {
                    _score += 10 +
                              strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    _score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    _score += sumOfBallInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return _score;
        }

        private int sumOfBallInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
        private int spareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }
        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1]==10;

        }
    }
}
