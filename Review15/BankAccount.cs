using System;
namespace Review15
{
    public abstract class BankAccount
    {
        public BankAccount()
        {
        }

        private int balance = 1000;


        public bool Saved = true;


        public virtual void SayBalance()
        {
            Console.WriteLine(balance);
        }

        public abstract void GreetCustomer();


        public void GetBalance()
        {
            Console.WriteLine("What is password?");
            if(Console.ReadLine() == "1234")
            {
                Console.WriteLine(balance);
            }
        }


        private void Quit()
        {
            Console.WriteLine("Quitting");
        }


        public void SaveandQuit()
        {
            if(Saved == true)
            {
                Quit();
            }
        }


    }
}
