using System;
using System.Net;
using System.Xml.Serialization;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void Menu()
    {
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Welcome to your Daily Journal!\n");

            DailyQuote quote = new DailyQuote();
            Console.WriteLine(quote.GetRandomQuote());

            Console.WriteLine("\nPlease select one of the following choices:\n");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("\nWhat would you like to do?\n");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                NewJournalEntry();
                Console.WriteLine();

            }

            else if (choice == 2)
            {
                DisplayJournalEntries();

            }

            else if (choice == 3)
            {
                Console.WriteLine("Please type the file where your journal will load:");
                string fileName = Console.ReadLine();
                LoadJournalFromFile(fileName);
            // for this assignment the file Journal.txt was created but the user can decide
            //which file to save to and load from
            }

            else if (choice == 4)
            {
                Console.WriteLine("Please type the file where your journal will be saved:");
                string fileName = Console.ReadLine();
                SaveJournalToFile(fileName);

            }

            else if (choice == 5)
            {
                Console.WriteLine("Have a great day!");
                System.Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Invalid choice. Press enter to continue...");
                Console.ReadLine();
            }
        }


    }


    public void NewJournalEntry()
    {
        Entry entry = new Entry();
        entry.AddEntry();
        _entries.Add(entry);

    }

    public void DisplayJournalEntries()
    {
        foreach (Entry response in _entries)
        {
            response.PrintEntry();
        }

        Console.WriteLine("\nPress enter to continue");
        Console.ReadLine();

    }

    public void SaveJournalToFile(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var response in _entries)
                {
                    outputFile.WriteLine($"{response._date};{response._prompt};{response._userResponse}");
                }
        }
    }

    public void LoadJournalFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            DateTime date = DateTime.Parse(parts[0]);   
            string prompt = parts[1];
            string userResponse = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._userResponse = userResponse;
            _entries.Add(entry);
            
        }


    }

}






