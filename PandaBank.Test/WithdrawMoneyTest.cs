using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBank.Test
{
    [TestClass]
    public class WithdrawMoneyTest 
    {
        [TestMethod]
        public void Return_True_When_Trying_For_Negative_Account_Balance_After_Wihdrawl()
        {
            //Arrange
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");

            PandaBankTestClass wMoney = new PandaBankTestClass();
            //Act
            var expected = -1;
            var actual = wMoney.WithdrawelMoneyTest(Account1, 351);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
