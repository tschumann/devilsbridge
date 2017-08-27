﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace devilsbridge_tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "A null game was passed to the constructor.")]
        public void testInstantiateNull()
        {
            devilsbridge.DevilsBridgePlayer player = new devilsbridge.DevilsBridgePlayer(null);
        }
    }
}