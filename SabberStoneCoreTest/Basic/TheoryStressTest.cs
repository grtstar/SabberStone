﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SabberStoneCoreTest.Basic
{
    [TestClass]
    public class TheoryStressTest
    {
        // TODO TheoryStressTest Patashu - Heute um 14:00 Uhr
        // order of play, auras and on-death triggers are what really stresses your implementation
        // of sequences and phases and steps there's a couple of order of play based tests in the
        // brimstone tests class, added by me. they currently fail, see if you can make them pass :wink:
        // besides those, test things like battlecries that summon minions vs sword of justice,
        // violet teacher vs wild pyromancer, etc

        [TestMethod]
        public void PhaseTest()
        {

        }
    }
}
