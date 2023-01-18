using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal program");  

        string [] prompts = new string[7];

        prompts[0] = ("Who was the most interesting person I interacted with today?");
        prompts[1] = ("What was the best part of my day?");
        prompts[2] = ("How did I see the hand of the Lord in my life today?");
        prompts[3] = ("What was the strongest emotion I felt today?");
        prompts[4] = ("If I had one thing I could do over today, what would it be?");
        prompts[5] = ("What did I learn today from my relationship with God?");
        prompts[6] = ("What blessing comforted me or brought me the most joy today?");

        Random randomNumber = new Random();
        int number = randomNumber.Next(0,6);
        string randomPrompt = prompts[number];
        
        int quit = 5;
        int userChoice = -1;

        string journalFileName = "journal.txt"; // global variable for file name, test with journal.txt 

        while (userChoice != quit)
        {
            //ask for input number
            Console.WriteLine("Please select one of the following choices (1-5): ");

            Menu text1 = new Menu();   // class Options to display only  : use a class
            text1._option1 = "1. Write";   // 
            text1._option2 = "2. Display";
            text1._option3 = "3. Load";
            text1._option4 = "4. Save";
            text1._option5 = "5. Quit";
            text1.Display(); 
             
            // get input number from user: 
            Console.WriteLine("> : ");
            string userOption = Console.ReadLine();
            userChoice = int.Parse(userOption);

            if (userChoice == 1)
            {
                //---------------------------------------------- write entries: use a class
                //Show a random prompt from array:
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string journalEntry = Console.ReadLine();                
                //save their response, the prompt, and the date as an Entry.
                DateTime currentDateTime = DateTime.Now;
                string date = currentDateTime.ToShortDateString();  //date

                Entry entry1 = new Entry();  //-------------------------------???
                entry1._date = date;
                entry1._prompt = randomPrompt;
                entry1._entry = journalEntry;
                entry1.WriteJournal(journalFileName); // calls the function in Entry class and passes the fileName from our main()

                entry1.Display();

                // using (StreamWriter outputFile = File.AppendText(journalFileName)) // to write in file -----(how to use a class here?)
                // {
                //     // You can use the $ and include variables just like with Console.WriteLine
                //       outputFile.WriteLine($"Date: {date} --{randomPrompt}--- {journalEntry}");
                // } 
                
            }
            else if (userChoice == 2) //--------------------------Display file:
            {
                // Iterate through all entries in the journal and display them to the screen.

                string[] lines = System.IO.File.ReadAllLines(journalFileName);

                foreach (string line in lines){
                    string[] entries = line.Split(",");
                    foreach (string entry in entries){
                            string eachEntry = entry;
                            Console.WriteLine(eachEntry);
                    }    
                }
            }
            else if (userChoice == 3)   //--------------------------Load file :
            {
                // Prompt user for a filename, then load the journal (a complete list of entries) from that file.
                // This should replace any entries currently stored in memory.
                Console.Write("Enter the name of a file: ");
                string fileNameInput = Console.ReadLine();
                // string filename = "journal.txt" example;
                if (journalFileName != fileNameInput){
                    journalFileName = fileNameInput;
                }
                

            }
             else if (userChoice == 4) //----------------------------------- Save entries:
            {
                // Prompt the user for a filename and then save the current journal 
                //(the complete list of entries) to that file location.
                Console.Write("Enter the name of a file: ");
                string fileNameInput = Console.ReadLine();
                // string filename = "journal.txt" example;
                if (journalFileName != fileNameInput){
                    journalFileName = fileNameInput;
                    using (StreamWriter outputFile = File.AppendText(journalFileName)) // to write in file
                    {
                       // outputFile.WriteLine($"Date: {date} --{randomPrompt}--- {journalEntry}"); //  ------ a class here?
                    }  
                }
            }
            else
            {   
                Console.WriteLine("Goodbye:"); // code here
    
            }
        }
        
        Console.WriteLine("Journal program closed");
        Console.WriteLine();
    }
}