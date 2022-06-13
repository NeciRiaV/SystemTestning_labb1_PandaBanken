using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PandaBank.Test
{
    [TestClass]
    public class PandaBankTest
    {
        public string name { get; set; }
        public float balance { get; set; }
        public string currency { get; set; }

        public PandaBankTest(string _name, float _balance, string _currency)
        {
            name = _name;
            balance = _balance;
            currency = _currency;
        }



    }
    public class TransferAccountss
    {
        PandaBankTest Account1 = new PandaBankTest("Pay", 350, "SEK");
        PandaBankTest Account2 = new PandaBankTest("Home", 350, "SEK");
        PandaBankTest Account3 = new PandaBankTest("Home", 300, "USD");

        public List<PandaBankTest> ListOfAccounts = new List<PandaBankTest>();


        public void AddAccounts(PandaBankTest _Account)
        {
            ListOfAccounts.Add(_Account);
        }

        public void TransferMoneyToSameNameAccount(string accountFrom, string accountTo, string secondAccountTo)
        {
            float moneyAmmount = 100;
        }

   

}
}
