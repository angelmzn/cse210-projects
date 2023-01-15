using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        // define the functions
        //Welcome message
        void welcomeMessage()
        {
            Console.WriteLine("Welcome to this program!!");
        }
        // Ask for the user's name
        string userName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        int favNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        
        int square(int baseNumber){
            int squared = baseNumber * baseNumber;
            return squared;
        }

        welcomeMessage();
        string name = userName();
        int number = favNumber();
        int squared = square(number);

        Console.WriteLine("Nice to meet you " + name);
        Console.WriteLine("Your favorite number is " + number);
        Console.WriteLine("Your favorite number squared is " + squared);


}   


    
}