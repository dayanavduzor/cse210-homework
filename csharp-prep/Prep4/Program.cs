using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 4, Lists");

        List<int> numbers = new List<int>();
        int number = -1;
        int total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            numbers.Add(number);
        }
        //lenght of list : 
        //Console.WriteLine(numbers.Count);

        //to add numbers in list: 
        foreach (int num in numbers)
        {
            total += num;  
        }
        Console.WriteLine($"The sum is: {total}");
        
        // to find average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // to find maximum number:
        int maxNum = numbers[0];
        
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                // if new number greater than maxNum, maxNum found. 
                maxNum = num;
            }
        }

        Console.WriteLine($"The largest number is: {maxNum}"); 
    }
}