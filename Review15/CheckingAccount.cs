using System;
namespace Review15
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
        }

        public override void GreetCustomer()
        {
            Console.WriteLine("Hello!");
        }
    }
}
