using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    internal class CheckingAccount : Account
    {
       

        public override void CreateAccount()
        {

            base.CreateAccount();

            #region TypeOfAccount (Checking Account)

            TypeOfAccount = "Checking Account";
            Console.WriteLine($"Welcom \"{AccountHolder}\", Now You Can have Checking Account");
            #endregion

        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.13;
        }

    }
}
