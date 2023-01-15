using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);


        int guess = 0;
        int counter = 0;

        Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");
        
        while (guess != number) {
                guess = Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;
    
                if (guess < number)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + guess + ".");
                }
                else if (guess > number)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + guess + ".");
                }

            }
            Console.WriteLine("Well done! The answer was " + number);
            Console.WriteLine("It took you " + counter + " times.");
            Console.ReadLine();
        }
    }
