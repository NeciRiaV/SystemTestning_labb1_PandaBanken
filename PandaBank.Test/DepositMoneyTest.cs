using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PandaBank.Test
{
    [TestClass]
    public class DepositMoneyTest
    {
        [TestMethod]
        public void Return_True_If_Value_Less_Than_100_Is_Deposited()
        {
            //Arrange
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");
            PandaBankTestClass Account2 = new PandaBankTestClass("Home", 350, "SEK");
            PandaBankTestClass Account3 = new PandaBankTestClass("Home", 300, "SEK");

            PandaBankTestClass dMoney = new PandaBankTestClass();

            //Act
            var expected = 351;
            var actual = dMoney.DepositMoneyTest(Account1, 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
