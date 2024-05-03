namespace Banking_System_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            int user;
            bool flag;
            do
            {

                Console.WriteLine("1) Login");
                Console.WriteLine("2) Create Account");
                Console.WriteLine("-----------------------------");

                int userChoice;
                do
                {
                    Console.Write("Enter Your Choice : ");
                } while (!(int.TryParse(Console.ReadLine(), out userChoice)) && userChoice is 1 or 2);


                if (userChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("1) Saving Account");
                    Console.WriteLine("2) Checking Account");
                    Console.WriteLine("-----------------------------");
                    int userTypeOfAccount;
                    do
                    {
                        Console.Write("Enter Your Choice : ");
                    } while (!(int.TryParse(Console.ReadLine(), out userTypeOfAccount)) && userTypeOfAccount is 1 or 2);

                    if (userTypeOfAccount == 1)
                    {
                        SavingAccount savingAccount = new SavingAccount();
                        savingAccount.CreateAccount();
                       
                        bank.AddAccount(savingAccount);

                        Console.Clear();
                        Console.WriteLine("Your Account Details:");
                        Console.WriteLine("=======================================");
                        bank.GetAccountDetails(savingAccount);
                        Console.WriteLine("=======================================");
                        Console.WriteLine("");


                        #region Check AccountDetails After Withdrow or any Operation
                        Console.Clear();
                        Console.WriteLine("Your Account Details:");
                        Console.WriteLine("=======================================");
                        bank.GetAccountDetails(savingAccount);
                        Console.WriteLine("=======================================");
                        #endregion
                    }
                    else
                    {
                        CheckingAccount checkingAccount = new CheckingAccount();
                        checkingAccount.CreateAccount();
                        //Bank bank = new Bank();
                        bank.AddAccount(checkingAccount);

                        Console.Clear();
                        Console.WriteLine("Your Account Details:");
                        Console.WriteLine("=======================================");
                        bank.GetAccountDetails(checkingAccount);
                        Console.WriteLine("=======================================");
                        Console.WriteLine("");


                        #region Check AccountDetails After Withdrow or any Operation
                        Console.Clear();
                        Console.WriteLine("Your Account Details:");
                        Console.WriteLine("=======================================");
                        bank.GetAccountDetails(checkingAccount);
                        Console.WriteLine("=======================================");
                        #endregion
                    }
                }

                else
                {

                    Console.Clear();
                    int userAccountNumber;
                    do
                    {
                        Console.Write("Please Enter Your Account Number: ");
                    } while (!(int.TryParse(Console.ReadLine(), out userAccountNumber)));

                    Bank.FindAccount(userAccountNumber);

                }


                Console.WriteLine("");
                Console.Write("Press (1) To Return to the Main Menu, Press (2) To Finish \n");
                flag = int.TryParse(Console.ReadLine(), out user);
                Console.Clear();

            } while ( flag && user is 1 );
            
            Console.Clear();
            Console.WriteLine("Thank You :)");
        }

    }
}
