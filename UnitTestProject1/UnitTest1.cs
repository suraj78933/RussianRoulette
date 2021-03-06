using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Game G1 = new Game();
        [TestMethod]
        public void awayTrueOrFalse()
        {
            bool Actual = G1.awayTrueOrFalse(1);
            Assert.AreEqual(true, Actual);

        }

        [TestMethod]
        public void awayAdded()
        {
            int Actual = G1.awayAdded(1);
            Assert.AreEqual(1, Actual);
        }
    }
}
