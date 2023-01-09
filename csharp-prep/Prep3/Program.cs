using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello this is Magic Number!");
        //Console.WriteLine("What is the magic number?");
        //string numberInput = Console.ReadLine();
        //int number = int.Parse(numberInput);

        Random randomNumber = new Random();
        int number = randomNumber.Next(1,30);

        int guess = -1 ;
        string play = "yes";
        int count = 0;

        while (guess != number || play == "yes")
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            count += 1;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {   
                Console.WriteLine($"You guessed it in {count} intents");
                Console.Write("Do you want to play again? yes/no: ");
                play = Console.ReadLine();
                count = 0;
                number = randomNumber.Next(1,30);
            }
        }
        
        Console.WriteLine("Thank you for playing!");
    }
}