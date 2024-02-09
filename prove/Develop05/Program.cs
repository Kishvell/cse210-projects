using System;
using System.Collections.Generic;

// Base class for different kinds of goals
public abstract class Activity
{
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int Points { get; set; }

    public Activity(string description)
    {
        Description = description;
        Completed = false;
        Points = 0;
    }

    public abstract void Complete();

    public abstract int CalculatePoints();
}

// Derived class for physical goals
public class PhysicalGoal : Activity
{
    public PhysicalGoal(string description, int points) : base(description)
    {
        Points = points;
    }

    public override void Complete()
    {
        Completed = true;
    }

    public override int CalculatePoints()
    {
        return Points;
    }
}

// Derived class for mental goals
public class MentalGoal : Activity
{
    public MentalGoal(string description, int points) : base(description)
    {
        Points = points;
    }

    public override void Complete()
    {
        Completed = true;
    }

    public override int CalculatePoints()
    {
        return Points;
    }
}

// Derived class for spiritual goals
public class SpiritualGoal : Activity
{
    public SpiritualGoal(string description, int points) : base(description)
    {
        Points = points;
    }

    public override void Complete()
    {
        Completed = true;
    }

    public override int CalculatePoints()
    {
        return Points;
    }
}

public class User
{
    public string Name { get; set; }
    public int Score { get; set; }
    public List<Activity> Goals { get; set; }

    public User(string name)
    {
        Name = name;
        Score = 0;
        Goals = new List<Activity>();
    }

    public void AddGoal(Activity goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(Activity goal)
    {
        if (!goal.Completed)
        {
            goal.Complete();
            Score += goal.CalculatePoints();
            Console.WriteLine($"Completed: {goal.Description}. You earned {goal.CalculatePoints()} points!");
            Console.WriteLine($"Total score for {Name}: {Score}");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Goals for {Name}:");
        foreach (var goal in Goals)
        {
            string status = goal.Completed ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal.Description}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Get user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        User user = new User(userName);
        bool quit = false;

        while (!quit)
        {
            // Choose physical, mental, and spiritual goals
            Console.WriteLine("Choose a physical goal:");
            string physicalGoalDesc = Console.ReadLine();
            Console.WriteLine("Choose a mental goal:");
            string mentalGoalDesc = Console.ReadLine();
            Console.WriteLine("Choose a spiritual goal:");
            string spiritualGoalDesc = Console.ReadLine();

            // Add chosen goals to the user's list
            user.AddGoal(new PhysicalGoal(physicalGoalDesc, 100));
            user.AddGoal(new MentalGoal(mentalGoalDesc, 150));
            user.AddGoal(new SpiritualGoal(spiritualGoalDesc, 200));

            // Record events
            Console.WriteLine("\nDid you complete your goals? (yes/no)");
            string completedGoals = Console.ReadLine().ToLower();
            if (completedGoals == "yes")
            {
                Console.WriteLine("Enter the number of the goal you completed (1 for physical, 2 for mental, 3 for spiritual):");
                int goalCompleted = int.Parse(Console.ReadLine());
                user.RecordEvent(user.Goals[goalCompleted - 1]);  // Complete selected goal
            }
            else
            {
                Console.WriteLine("No goals completed this time.");
            }

            Console.WriteLine($"\nTotal score for {user.Name}: {user.Score}");

            if (user.Score >= 1000)
            {
                Console.WriteLine("Congratulations! You've leveled up!");
                user.Score = 0;  // Reset score
            }

            Console.WriteLine("\nDo you want to set new objectives? (yes/no)");
            string setNewObjectives = Console.ReadLine().ToLower();
            if (setNewObjectives != "yes")
            {
                quit = true;
            }

            if (!quit)
            {
                user.Goals.Clear();  // Clear previous goals
            }
        }
    }
}