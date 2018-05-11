using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using devilsbridge;

namespace devilsbridge_tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "A null game was passed to the constructor.")]
        public void testInstantiateNull()
        {
            DevilsBridgePlayer player = new DevilsBridgePlayer(null);
        }
    }
}
