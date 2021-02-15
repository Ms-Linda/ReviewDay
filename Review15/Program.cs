using System;
using System.Collections.Generic;

namespace Review15
{
    class Program
    {


        //enums


        public enum Heroes
        {
            Batman, Superman, SpiderMan
        }


        static void Main(string[] args)
        {


            Heroes hero = Heroes.Superman;



            Heroes hero2 = Heroes.Superman;


            //Arrays

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };


            //numbers[4] = 10;

            //numbers[numbers.Length] = 10;


            //numbers[2] = 10;


            


            //loops
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }




            foreach (var item in numbers)
            {
                sum += item;
            }




            //variables


            int x = 100;


            int y = 100;



            int a = x + y;


            var number = new Numbers();


            Console.WriteLine(number.x);




            //Methods

            //static

           var answer = Numbers.Add(1, 4);

            

            Console.WriteLine(answer);


            // non static

            var num = new Numbers();

            num.Name = "Janisha";

            num.SayName();


            var num2 = new Numbers();

            num2.Name = "Johnny";


            num2.SayName();


            num.MakeUpperCase("football");






            //Variables

            int newVar = 5;


            Console.WriteLine(newVar);


            var people = new List<string>();



            var isCool = true;






            //OOPS A PIE
            //4 pillars
            //Inheritance

            var bear = new Bear();

            bear.Name = "Pooh Bear";






            //Encapsulation

            //var bankAccount = new BankAccount();

            //bankAccount.GetBalance();
            //bankAccount.SaveandQuit();


            //Abstraction
            var account1 = BankAccountFactory.CreateAccount();

            //Polymorphism

            Greeting(40);




            // abstract class

            var savings = new SavingsAccount();

            savings.SayBalance();

            //interfaces


            var bear2 = new Bear();

            bear2.Roaring();




            //switch statements vs if
            var fizz = 15;

            if(fizz % 3 == 0 && fizz % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(fizz % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(fizz % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }


            Console.WriteLine("What is your favorite color?");

            var color = Console.ReadLine();

            switch (color)
            {

                case "yellow":
                    Console.WriteLine("Nice");
                    break;
                case "purple":
                    Console.WriteLine("cool");
                    break;
                case "red":
                    Console.WriteLine("groovy");
                    break;
                case "auburn":
                    Console.WriteLine("awesome");
                    break;
                default:
                        Console.WriteLine("Ok");
                    break;
            }


            //problem solving googling


            //Testing

            //access modifiers



        }

        public static void Greeting()
        {
            Console.WriteLine("Hello!");
        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }


        public static void Greeting(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Hello!");
            }
        }

        public static void Greeting(bool yes)
        {
            if(yes == true)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
