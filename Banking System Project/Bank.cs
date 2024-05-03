using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    internal class Bank
    {


        #region Attributes
        public int NumberOfAccounts { get; set; }
        public static List<Account> Accounts { get; set; }
        #endregion


        #region Constructor
        public Bank()
        {
            Accounts = new List<Account>();
        }
        #endregion


        #region Methods


        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }


        //Handl in Console
        public void GetAccountDetails(Account account)
        {
            int index = Accounts.IndexOf(account);
            if (Accounts != null && index != -1)
            {

                Console.WriteLine($"Your Account ID: {Accounts[index].Id}");
                Console.WriteLine($"Your Account Number: {Accounts[index].AccountNumber}");
                Console.WriteLine($"Your Account Name: {Accounts[index].AccountHolder}");
                Console.WriteLine($"Your Account Balance: {Accounts[index].Balance}");
                //Because Interest Property is Protected
                //Console.WriteLine($"Your Account Number: {account.Interest}");
            }

        }


        public static void FindAccount(int accountNumber)
        {
            if (Accounts.Count != 0)
            {
                for (int i = 0; i < Accounts?.Count; i++)
                {

                    if (Accounts[i].AccountNumber == accountNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("1) Withdrow");
                        Console.WriteLine("2) Deposit");
                        Console.WriteLine("3) Check Your Balance");
                        Console.WriteLine("4) Logout");
                        Console.WriteLine("===================================");

                        int userChoiceTheOperation;
                        do
                        {
                            Console.Write("Please Enter Your Choice: ");
                        } while (!(int.TryParse(Console.ReadLine(), out userChoiceTheOperation)) && userChoiceTheOperation is 1 or 2 or 3 or 4);

                        switch (userChoiceTheOperation)
                        {
                            case 1:
                                Accounts[i].Withdrow();
                                break;
                            case 2:
                                Accounts[i].Deposit();
                                break;
                            case 3:
                                Accounts[i].GetBalance();
                                break;
                            default:
                                Console.WriteLine("Thank You :)");
                                break;

                        }

                    }
                    
                    else
                        Console.WriteLine("Invalid Account Number");

                }
            }
            
            else
                Console.WriteLine("Invalid Account Number");
        }


        public void CalculateTotalBalance()
        {
            double TotalBalance = 0;
            for (int i = 0; i < Accounts.Count; i++)
            {
                TotalBalance += Accounts[i].Balance;
            }
            Console.WriteLine($"Total Balance: {TotalBalance}");
        }



        #endregion
    }


}
