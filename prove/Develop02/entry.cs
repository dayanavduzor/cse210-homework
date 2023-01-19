using System;

public class Entry
{   
    public string _prompt = "";
    public string _entry = "";
    public string _date = "";
    
    public List<string> paragraphs = new List<string>();
    public void Add()
    {
        paragraphs.Add($"Date {_date} {_prompt} -- {_entry}");
    }

}

