using System;
public class Entry
{
 
    public DateTime _date;
    public string _prompt;
    public string _userResponse;

    public void AddEntry()
    {
        _date = DateTime.Now;

        Prompt prompt = new Prompt();
        _prompt = prompt.GetRandomQuestion();

        Console.WriteLine(_prompt);
        _userResponse = Console.ReadLine();

    }

    public void PrintEntry()
    {
       Console.WriteLine(_date);
       Console.WriteLine(_prompt);
       Console.WriteLine(_userResponse);
    }

}