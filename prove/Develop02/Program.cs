using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World! ");
        Journal journal = new Journal();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("Somebody Once said; " + Affirmations.GetRandomPrompt());
                    Console.WriteLine("");
                    Console.WriteLine("Random prompt: " + journal.GetRandomPrompt());
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string filenameToSave = Console.ReadLine();
                    journal.SaveToFile(filenameToSave);
                    break;
                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string filenameToLoad = Console.ReadLine();
                    journal.LoadFromFile(filenameToLoad);
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
class Affirmations
{
        private static List<string> prompts = new List<string>
        {
            // Think of other problems that keep people from writing in their journal and address one of those.
            // Avoiding self-criticism can be a challenging but essential aspect of maintaining a healthy and positive mindset.
            "My purpose: to lift your spirit and to motivate you. — Mavis Staples",
            // 1.Practice self compassion.
            "You're braver than you believe, and stronger than you seem, and smarter than you think. — A.A. Mine",
            // 2.Challenge negative thoughts.
            "Once you replace negative thoughts with positive ones, you'll start having positive results. - Willie Nelson",
            // 3.Focus on growth.
            "Nothing is impossible, the word itself says 'I'm possible'. — Audrey Hepburn ",
            // 4.Set realistic standards.
            "We cannot direct the wind, but we can adjust the sails. — Dolly Parton",
            // 5.Practice gratitud.
            "Great things happen to those who don't stop believing, trying, learning, and being grateful. ― Roy T. Bennett",
            // 6.Use affirmations
            "You are never too old to set another goal or to dream a new dream. - C.S.Lewis",
            // 7.Seek support.
            "Needing help doesn't have a look, but asking for it always looks beautiful. ― Brittany Burgunder",
            // 8.Mindfullness and self acceptance.
            "Find out who you are and do it on purpose. — Dolly Parton",
            // 9.Celebrate Archivments.
            "When you take ownership of your acomplishments, you can be proud without arrogance. - Simon Sinek",
            // 10.Focus on solutions.
            "If the challenge exists, so must the solution. - Rona Mlnarik"
        };

        public static string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
}

class Journal
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private List<Entry> entries = new List<Entry>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    
    public void AddEntry(string response)
    {
        string prompt = GetRandomPrompt();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(prompt, response, date);
        entries.Add(newEntry);
    }


    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
        }
    }

    public void SaveToFile(string filename)
    {
            try
            {
                using (FileStream fs = File.Create(filename))
                {
                    JsonSerializer.SerializeAsync(fs, entries);
                }
                Console.WriteLine("Journal saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal to file: {ex.Message}");
            }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                using (FileStream fs = File.OpenRead(filename))
                {
                    entries = JsonSerializer.DeserializeAsync<List<Entry>>(fs).Result;
                }
                Console.WriteLine("Journal loaded from file successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}
