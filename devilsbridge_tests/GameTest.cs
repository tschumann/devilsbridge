using Microsoft.VisualStudio.TestTools.UnitTesting;
using devilsbridge;

namespace devilsbridge_tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void testCreateGame()
        {
            int playerCount = 1;
            Game game = new Game(playerCount);
            Assert.AreEqual(game.getPlayers().Count, playerCount);
        }
    }
}
