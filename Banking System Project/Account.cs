using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    internal abstract class Account
    {

        #region Attributes
        public long Id { get; set; }

        public static int lastestAccountNumber = 2024000;
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        protected double Interest { get; set; }
        protected string TypeOfAccount { get; set; }
        #endregion


        #region Constructor
        public Account()
        {
            lastestAccountNumber++;
            AccountNumber = lastestAccountNumber;
        }
        #endregion


        #region Methods

        public virtual void CreateAccount() 
        {

            Console.Clear();


            #region Id
            string userId;
            bool isValidInput = false;
            do
            {
                Console.Write("Please enter your ID: ");
                userId = Console.ReadLine();

                if (IsNumeric(userId) && userId.Length == 14)
                    isValidInput = true;
                else
                    Console.WriteLine("Invalid input. Please enter a 14-digit numeric ID.");


            } while (!isValidInput);

            Id = long.Parse(userId);
            #endregion


            #region Account Holder
            do
            {
                Console.Write("Please Enter Your Name: ");
                AccountHolder = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(AccountHolder));
            #endregion


            #region Balance 
            //(Handle Error of decimal)
            double userBalance;
            do
            {
                Console.Write("Please Enter Your Balance you want to save: ");
            } while (!(double.TryParse(Console.ReadLine(), out userBalance)) && userBalance >= 0);

            Balance = userBalance;
            #endregion


            #region Account Number
            Console.WriteLine($"Your Account Number is: {AccountNumber}");
            #endregion

        }


        //public void Login() { }

        static bool IsNumeric(string str)
        {
            foreach(char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

 

        public abstract void CalculateInterest();


        public void Withdrow() 
        {
            Console.Clear();
            int userInputWithdrow;
            do
            {
                Console.Write("Please Enter Your Number You Want to Withdrow: ");
            } while (!(int.TryParse(Console.ReadLine(), out userInputWithdrow)));

            if (userInputWithdrow <= Balance)
            {
                Balance -= userInputWithdrow;
                Console.WriteLine("Success, Thank You :)");
            }
                
            else
                Console.WriteLine($"Your Balance is Less than ({userInputWithdrow})");

        }


        public void Deposit() 
        {
            Console.Clear();
            int userInputDeposit;
            do
            {
                Console.Write("Please Enter Your Number You Want to Deposit: ");
            } while (!(int.TryParse(Console.ReadLine(), out userInputDeposit)));

            if (userInputDeposit <= 20_000 && userInputDeposit > 0)
            {
                Balance += userInputDeposit;
                Console.WriteLine("Success, Thank You :)");
            }

            else
                Console.WriteLine($"Please Enter Number is Less than (20_000)");
        }


        public void GetBalance() 
        {
            Console.Clear();
            Console.WriteLine($"Your Balance is : {Balance:c}");
        } 

        #endregion


    }
}
