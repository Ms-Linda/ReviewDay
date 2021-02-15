using System;
namespace Review15
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
        }

        public string UserName { get; set; }

        public override void GreetCustomer()
        {
            Console.WriteLine(UserName);
        }


        public override void SayBalance()
        {
            Console.WriteLine($"Your balance is:");
            GetBalance();
        }



        public void Example()
        {
            this.SayBalance();
            base.SayBalance();
        }
    }
}
