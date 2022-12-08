using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // Change the appearance

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 40;

            // Get a conversation going

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine(); // This works too

            Console.WriteLine("My name is RX-9000. \nI'm an AI sent from the future to destroy mankind.");
            Console.WriteLine("What is your favorite color?");

            Console.ReadLine();

            Console.WriteLine("Cool! Mine is destruction");

            Console.ReadKey();
        }
    }
}


            