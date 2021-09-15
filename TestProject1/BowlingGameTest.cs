using ClassLibrary1;
using Xunit;

namespace TestProject1
{
    public class BowlingGameTest
    {
        private Game _game;
      

        private void MakeXRolls(int rundor,int kälgorSlogs)
        {
            for (int i = 0; i < rundor; i++)
            {
                _game.Roll(kälgorSlogs);
            }
        }
        public BowlingGameTest()
        {
           
            _game = new Game();
        }
        [Fact]
        public void BowlingTest()
        {

            MakeXRolls(20, 0);
            Assert.Equal(0,_game.Score());
        }

        [Fact]
        public void AllBowlingTest()
        {
            MakeXRolls(20, 1);
            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void testOneSpare()
        {
           rollSpare();
            _game.Roll(3);
            MakeXRolls(17, 0);
            Assert.Equal(16, _game.Score());
        }

        [Fact]
        public void testOneStrike()
        {
            _game.Roll(10); //strike
            _game.Roll(3);
            _game.Roll(4);
            MakeXRolls(16,0);
            Assert.Equal(24,_game.Score());
        }
        private void rollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }
    }
}
