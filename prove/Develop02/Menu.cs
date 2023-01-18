using System;

public class Menu
{   
    
    public string _option1 = "";
    public string _option2 = "";
    public string _option3 = "";
    public string _option4 = "";
    public string _option5 = "";

    public void Display()
    {
        Console.WriteLine($"{_option1 }");
        Console.WriteLine($"{_option2 }");
        Console.WriteLine($"{_option3 }");
        Console.WriteLine($"{_option4 }");
        Console.WriteLine($"{_option5 }");
    }
}