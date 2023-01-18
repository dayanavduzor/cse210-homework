using System;

public class Entry
{   
    public string _prompt = "";
    public string _entry = "";
    public string _date = "";
    
    public void Display()
    {
        Console.WriteLine($"Date {_date} {_prompt} -- {_entry}");
    }

    public void WriteJournal(string journalFileName){
        using (StreamWriter outputFile = File.AppendText(journalFileName)) // to write in file -----(how to use a class here?)
        {
            // You can use the $ and include variables just like with Console.WriteLine
                outputFile.WriteLine($"Date: {_date} --{_prompt}--- {_entry}");
        }
    }
    
    

}

