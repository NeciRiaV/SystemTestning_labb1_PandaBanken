using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaBank
{
    public class PandaBankTestClass
    {
        public string name { get; set; }
        public float balance { get; set; }
        public string currency { get; set; }
        public bool isSavings { get; set; }

        public PandaBankTestClass(string _name, float _balance, string _currency)
        {
            name = _name;
            balance = _balance;
            currency = _currency;
        }
    }
    public class TransferAccounts
    {
        public List<PandaBankTestClass> ListOfAccounts = new List<PandaBankTestClass>();
        public void AddAccounts(PandaBankTestClass _accounts)
        {
            ListOfAccounts.Add(_accounts);
        }
        


        public bool TransferMoneyToSameNameAccountTest(PandaBankTestClass accountFrom,PandaBankTestClass accountTo)
        {
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");
            PandaBankTestClass Account2 = new PandaBankTestClass("Home", 350, "SEK");
            PandaBankTestClass Account3 = new PandaBankTestClass("Home", 300, "SEK");

            ListOfAccounts.Add(Account1);
            ListOfAccounts.Add(Account2);
            ListOfAccounts.Add(Account3);

            string account1 = "Pay";
            accountFrom = ListOfAccounts.Find(s => s.name == account1);
            while (accountFrom == null)
            {
                Console.WriteLine("First account not found");
                return false;
            }
            string account2 = "Home";
            accountTo = ListOfAccounts.Find(r => r.name == account2);
            while (account2 == null)
            {
                Console.WriteLine("Second account not found");
                return false;
            }
            Console.WriteLine("Account found");
            return true;
        } 
    }

    public class WithdrawMoney 
    {
        public List<PandaBankTestClass> ListOfAccounts = new List<PandaBankTestClass>();
        public void AddAccounts(PandaBankTestClass _accounts)
        {
            ListOfAccounts.Add(_accounts);
        }

        public float WithdrawelMoneyTest(PandaBankTestClass account, float moneyWithdrawn)
        {
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");
            ListOfAccounts.Add(Account1);

            //Konto att ta pengar från
            string withdrawAccount = "Pay";
            PandaBankTestClass account1 = ListOfAccounts.Find(s => s.name == withdrawAccount);
            while (Account1 == null)
            {
                Console.WriteLine("Fail! Wrong account name!");
            }
            //Mängd pengar att ta ut
            float moneyAmount = 0;
            bool isException = false;
            do
            {
                try
                {
                    moneyAmount = moneyWithdrawn;
                    isException = false;
                }
                catch (Exception)
                {
                    Console.Write("Ogiltigt format! Vänligen skriv in ett nytt belopp: ");
                    isException = true;
                }
            }
            while (isException);
            Console.WriteLine("Withdrawl approved");
            return account1.balance -= moneyAmount; //egen tillagd kod för att returnera
            //SaveCalculations(moneyAmount, 0, Account1, null);
        }
    }

    public class DepositMoney
    {
        public List<PandaBankTestClass> ListOfAccounts = new List<PandaBankTestClass>();
        public void AddAccounts(PandaBankTestClass _accounts)
        {
            ListOfAccounts.Add(_accounts);
        }

        public float DepositMoneyTest(PandaBankTestClass depositAccount, float moneyDeposit)
        {
            PandaBankTestClass Account1 = new PandaBankTestClass("Pay", 350, "SEK");
            PandaBankTestClass Account2 = new PandaBankTestClass("Home", 350, "SEK");
            PandaBankTestClass Account3 = new PandaBankTestClass("Home", 300, "SEK");

            ListOfAccounts.Add(Account1);
            ListOfAccounts.Add(Account2);
            ListOfAccounts.Add(Account3);

            string depositText = "Pay";
            depositAccount = ListOfAccounts.Find(s => s.name == depositText);
            while (depositAccount == null)
            {
                Console.Write("Account not found!");
            }
            float moneyAmount = 0;
            bool isException = false;
            do
            {
                try
                {
                    moneyAmount = moneyDeposit;
                    isException = false;
                }
                catch (Exception)
                {
                    Console.Write("Ogiltigt format! Vänligen skriv in ett nytt belopp: ");
                    isException = true;
                }
            }
            while (isException);

            if (depositAccount.isSavings == true)
            {
                decimal IntrestRate = 0.01M;
                decimal YearlyAmount = IntrestRate * (decimal)moneyAmount;
                Console.WriteLine("Om räntan är " + IntrestRate * 100 + "% kommer du att få en årlig bonus på: " + Math.Round(YearlyAmount, 2));
            }
            depositAccount.balance += moneyAmount;
            return depositAccount.balance = (float)Math.Round(depositAccount.balance, 2);
        }
    }
}
