using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine($"Your First name is {first_name}");
        Console.WriteLine("");
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your last name is " + last_name);
        Console.WriteLine("");
        Console.WriteLine($"Your name is {first_name} {last_name}");


    }
}