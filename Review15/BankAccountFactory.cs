using System;
namespace Review15
{
    public class BankAccountFactory
    {
        public BankAccountFactory()
        {
        }





        public  static BankAccount CreateAccount()
        {
            Console.WriteLine("What type of account would you like to open?");
            Console.WriteLine("Press 1 for checking");
            Console.WriteLine("Press 2 for savings");
            var input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                return new CheckingAccount();
            }
            if(input == 2)
            {
                return new SavingsAccount();
            }
            else
            {
                return new CheckingAccount();
            }

        }
    }
}
