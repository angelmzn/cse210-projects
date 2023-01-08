using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Hi, welcome to the grade checker! ");
        Console.Write("What is your grade percentage?");
        float grades = float.Parse(Console.ReadLine());
        

        string letter = "";

        if (grades < 60) 
        {
            letter = "F";
            Console.Write("I am sorry, please try again next semester ");
        }
        else if (grades < 70 && grades >= 60 )
        {
            letter = "D";
            Console.Write("Congratulations, you passed the course! ");
        }
        else if (grades < 80 && grades >=70 )
        {
            letter = "C";
            Console.Write("Congratulations, you passed the course! ");
        }
        else if (grades < 90 && grades >= 80 )
        {
            letter = "B";
            Console.Write("Congratulations, you passed the course! ");
        }
        else if (grades <= 100 && grades >= 90 )
        {
            letter = "A";
            Console.Write("Congratulations, you passed the course! ");
        }
        
        Console.Write($"Your grade is {letter}.");

    }
}