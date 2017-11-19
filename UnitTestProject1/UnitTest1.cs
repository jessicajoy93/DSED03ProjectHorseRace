using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED03ProjectHorseRace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Punter[] myGuy = new Punter[3];
        Tortoise[] myTortoise = new Tortoise[4];
        Property myProperty = new Property();

        [TestMethod]
        public void Guy()
        {
            int id = 2;
            int result = Convert.ToInt16(Factory.GetAGuy(id).GuyID);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Number()
        {
            int result = Factory.Number();
            Assert.IsTrue(result > 0 && result < 10);
        }
    }
}
