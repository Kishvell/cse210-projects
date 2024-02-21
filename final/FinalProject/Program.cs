using System;
using System.Collections.Generic;

class UserInterface
{
    public void DisplayMenu()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Add Expense");
        Console.WriteLine("2. Add Income");
        Console.WriteLine("3. Track Budget");
        Console.WriteLine("4. Set Budget Goal");
        Console.WriteLine("5. Track Budget Goals");
        Console.WriteLine("6. Exit");
        Console.WriteLine("------------------------");
        Console.WriteLine("");
    }
}

// In the provided code, the principle of abstraction is applied through the Budget class.

// The principle of encapsulation is applied throughout the provided code, particularly within the Budget class and its methods.

class Budget
{
    private decimal totalIncome;
    private decimal totalExpenses;
    private decimal budgetGoalExpense;
    private decimal budgetGoalIncome;
    private List<(string, decimal)> expenses = new List<(string, decimal)>();
    private List<(string, decimal)> incomes = new List<(string, decimal)>();

    public void AddExpense(string name, decimal amount)
    {
        totalExpenses += amount;
        expenses.Add((name, amount));
    }

    public void AddIncome(string name, decimal amount)
    {
        totalIncome += amount;
        incomes.Add((name, amount));
    }

    public void TrackBudgetDetails()
    {
        Console.WriteLine("Expenses:");
        foreach (var expense in expenses)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Name: {expense.Item1}, Amount: {expense.Item2}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
        }

        Console.WriteLine("\nIncomes:");
        foreach (var income in incomes)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Name: {income.Item1}, Amount: {income.Item2}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
        }
    }

    public void SetBudgetGoal()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Do you wish to set a goal?");
        Console.WriteLine("1. Set Expense Goal");
        Console.WriteLine("2. Set Income Goal");
        Console.WriteLine("3. Return to Main Menu");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter expense goal amount: ");
                budgetGoalExpense = decimal.Parse(Console.ReadLine());
                break;
            case "2":
                Console.Write("Enter income goal amount: ");
                budgetGoalIncome = decimal.Parse(Console.ReadLine());
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public void TrackBudgetGoals()
    {
        if (budgetGoalExpense > 0)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Expense Goal: " + budgetGoalExpense);
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
        }
        if (budgetGoalIncome > 0)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Income Goal: " + budgetGoalIncome);
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
        }
    }
}

class Program
{
    static void Main()
    {
        UserInterface ui = new UserInterface();
        Budget budget = new Budget();

        bool running = true;
        while (running)
        {
            ui.DisplayMenu();
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("How would you like to name the expense? ");
                    string expenseName = Console.ReadLine();
                    Console.Write("How much did you expend? ");
                    decimal expenseAmount = decimal.Parse(Console.ReadLine());
                    budget.AddExpense(expenseName, expenseAmount);
                    break;
                case "2":
                    Console.Write("How would you like to name the income you received? ");
                    string incomeName = Console.ReadLine();
                    Console.Write("How much did you receive? ");
                    decimal incomeAmount = decimal.Parse(Console.ReadLine());
                    budget.AddIncome(incomeName, incomeAmount);
                    break;
                case "3":
                    budget.TrackBudgetDetails();
                    break;
                case "4":
                    budget.SetBudgetGoal();
                    break;
                case "5":
                    budget.TrackBudgetGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

// The principle of inheritance is not explicitly applied.
// Inheritance allows a new class to inherit properties and behaviors from an existing class,
// promoting code reusability and the creation of class hierarchies.
// This supports modularity and organized code.

// The principle of polymorphism is not explicitly implemented.
// Polymorphism allows different objects to be treated as instances of a common superclass,
// enabling flexible and extensible code.