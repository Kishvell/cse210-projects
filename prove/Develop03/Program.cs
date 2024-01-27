using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public string Reference { get; }
    public string Text { get; private set; }
    
    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public void HideRandomWords()
    {
        string[] words = Text.Split(' ');
        Random random = new Random();
        int index = random.Next(words.Length);
        words[index] = new string('_', words[index].Length);
        Text = string.Join(" ", words);
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{Reference}: {Text}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Develop03 World!");
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        string scriptureReference = "John 3:16";
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        string userInput = "";
        while (userInput != "quit")
        {
            scripture.DisplayScripture();
            Console.Write("Press Enter to continue or type 'quit' to end: ");
            userInput = Console.ReadLine();
            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords();
            }
        }
    }
}