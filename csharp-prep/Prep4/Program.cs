using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0){
            Console.WriteLine("Enter numbers or type 0 to stop");
            //It saves the value input by the user
            string userInput = Console.ReadLine();

            number = int.Parse(userInput);

            // If the number is not a 0, add it to the list
            if (number != 0) {
                numbers.Add(number);
            }
        }

        //Calculate the sum
        int sum = 0;

        foreach(int i in numbers) 
        {
            sum += i;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        //compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is amount in the list is: {average}");


        int maxNumber = numbers[0];
        foreach (int i in numbers){
            if (i > maxNumber)
            {
                maxNumber = i;
            }
        }

        Console.WriteLine($"The max number is: {maxNumber}");

        //sort the list

        
    }
}