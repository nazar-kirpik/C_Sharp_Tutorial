using System;

namespace My_Awesome_Program
{

    class Program7
    {

        static void Main(string[] args) {
            int result = Multiply(3, 8);

            Console.WriteLine("The result is: " + result);

            if (result % 2 == 0) 
            {
                Console.WriteLine(result + " is an even number!");
            } else 
            {
                Console.WriteLine(result + " is an uneven number!");
            }
            
            Console.ReadKey();
        }

        static void MeetAlien() 
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm" + name);
            Console.WriteLine("I'm" + age + "years old.");
            Console.WriteLine("Oh, and I'm an alien");
        }

        static int Multiply (int num1, int num2) 
        {
            int result = num1 * num2;
            return result;
        }
    }
}
