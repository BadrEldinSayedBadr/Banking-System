using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    internal class SavingAccount : Account
    {


        public override void CreateAccount()
        {

            base.CreateAccount();

            #region TypeOfAccount (Saving Account)
            TypeOfAccount = "Saving Account";
            Console.WriteLine($"Welcom \"{AccountHolder}\", Now You Can have Saving Account");
            #endregion

        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.19;
        }
    }
}
