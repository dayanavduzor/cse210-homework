using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fisrtName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {fisrtName} {lastName}");
    }
}