using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBank.Test
{
    [TestClass]
    public class TransferMoneyTest
    {
        [TestMethod]
        public void Return_True_Even_When_Multiple_Accounts_Share_Name() 
        {
            //Arrange
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");
            PandaBankTestClass Account2 = new PandaBankTestClass("Home", 350, "SEK");
            PandaBankTestClass Account3 = new PandaBankTestClass("Home", 300, "USD");

            PandaBankTestClass transfer = new PandaBankTestClass();
            string test = "Home";

            //Action
            var expected = true;
            var actual = transfer.TransferMoneyToSameNameAccountTest(Account1, Account2);

            

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
