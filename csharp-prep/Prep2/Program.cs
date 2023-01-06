using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that determines the letter grade for a course according to the following scale:
        
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string percentageInput = Console.ReadLine();
        int percentage = int.Parse(percentageInput);

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // congratulations/ encourage statement:
        if (percentage >= 70)
        {
            Console.WriteLine($"Congraturlations you passed!. Your grade is {letter}");
        }
        else 
        {
            Console.WriteLine($"Keep trying to pass next time, you can do it! Your grade is {letter}");
        }

    
    }
}