using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Develop04 World!");
        while (true)
        {
            Console.WriteLine("Welcome to the Wellness Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActivity();
                    break;
                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartActivity();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.StartActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

// Base class for wellness activities
class WellnessActivity
{
    protected string activityName;
    protected int duration;

    public virtual void StartActivity()
    {
        StandardStartingMessage(activityName);
    }

    protected void StandardStartingMessage(string activityDescription)
    {
        Console.WriteLine($"Starting {activityDescription}...");
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected void StandardFinishingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {activityName} for {duration} seconds.");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine("Wellness Program has finished.");
    }
}

// Subclass for Breathing Activity
class BreathingActivity : WellnessActivity
{
    public BreathingActivity()
    {
        activityName = "Breathing Activity";
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Clear your mind and focus on your breathing.");

        Console.WriteLine("Starting breathing activity...");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds

            // Show countdown
            int remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
            Console.WriteLine($"Time remaining: {remainingSeconds} seconds");
        }

        StandardFinishingMessage();
    }
}

// Subclass for Reflection Activity
class ReflectionActivity : WellnessActivity
{
    private string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectiveQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        activityName = "Reflection Activity";
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Console.WriteLine("This will help you recognize your power and how you can use it in your life.");

        Console.WriteLine("Starting reflection activity...");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            // Select a random prompt
            string randomPrompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];
            Console.WriteLine(randomPrompt);

            // Ask reflective questions
            foreach (string question in reflectiveQuestions)
            {
                Console.WriteLine(question);
                //Pause for several seconds and display a spinner
                Thread.Sleep(3000); // Pause for 3 seconds
                Console.Write("\b/");
                Thread.Sleep(3000);
                Console.Write("\b-");
                Thread.Sleep(3000);
                Console.Write("\b\\");
                Thread.Sleep(3000);
                Console.Write("\b|");
                Thread.Sleep(300);
                Console.Write("\b");
            }
        }

        StandardFinishingMessage();
    }
}

// Subclass for Listing Activity
class ListingActivity : WellnessActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        activityName = "Listing Activity";
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Console.WriteLine("This will help you reflect on the good things in your life.");

        Console.WriteLine("Starting listing activity...");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        // Select a random prompt
        string randomPrompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(randomPrompt);

        Console.WriteLine("You have a few seconds to begin thinking about the prompt...");
        Thread.Sleep(5000); // Countdown for 5 seconds

        Console.WriteLine("Start listing items:");

        // Timer for listing items
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"Number of items listed: {itemCount}");

        StandardFinishingMessage();
    }
}