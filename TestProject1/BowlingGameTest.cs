using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Xunit;

namespace TestProject1
{
   public class BowlingGameTest
    {
        [Fact]
        public void BowlingTest()
        {
            Game game = new();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.Equal(0,game.Score());
        }
    }
}
