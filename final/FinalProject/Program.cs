using System;
using System.Collections.Generic;

// UserInterface class responsible for handling user input and providing a user-friendly interface
class UserInterface
{
    // Method to get user input for adding an expense category
    public string GetUserInputForExpenseCategory()
    {
        Console.WriteLine("Enter the name of the expense category: ");
        return Console.ReadLine();
    }

    // Method to display a budget report to the user
    public void DisplayBudgetReport(string report)
    {
        Console.WriteLine("Budget Report:");
        Console.WriteLine(report);
    }
}

// DataStorage class responsible for handling the storage and retrieval of budget-related data
class DataStorage
{
    // Method to save budget data to a file
    public void SaveBudgetData(string data)
    {
        // Implementation for saving data to a file
        Console.WriteLine("Saving budget data to a file...");
    }
}

// BudgetManagementSystem class responsible for coordinating budget-related operations
class BudgetManagementSystem
{
    private double budgetBalance;
    private List<string> expenseCategories;
    private List<string> incomeSources;

    public BudgetManagementSystem()
    {
        budgetBalance = 0.0;
        expenseCategories = new List<string>();
        incomeSources = new List<string>();
    }

    // Method to add a new expense category to the collection
    public void AddExpenseCategory(string category)
    {
        expenseCategories.Add(category);
        Console.WriteLine("Expense category added: " + category);
    }

    // Method to add a new income source to the collection
    public void AddIncomeSource(string source)
    {
        incomeSources.Add(source);
        Console.WriteLine("Income source added: " + source);
    }

    // Method to update the budget balance based on income and expenses
    public void UpdateBudgetBalance(double income, double expenses)
    {
        budgetBalance += income - expenses;
        Console.WriteLine("Budget balance updated: " + budgetBalance);
    }

    // Method to generate a basic budget report
    public string GenerateBasicReport()
    {
        string report = "Budget Report: \n" +
                        "Balance: " + budgetBalance + "\n" +
                        "Expense Categories: " + string.Join(", ", expenseCategories) + "\n" +
                        "Income Sources: " + string.Join(", ", incomeSources) + "\n";
        return report;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        // Instantiate the classes
        UserInterface userInterface = new UserInterface();
        DataStorage dataStorage = new DataStorage();
        BudgetManagementSystem budgetSystem = new BudgetManagementSystem();

        // Simulate user interaction
        string newExpenseCategory = userInterface.GetUserInputForExpenseCategory();
        budgetSystem.AddExpenseCategory(newExpenseCategory);

        budgetSystem.AddIncomeSource("Salary");
        budgetSystem.AddIncomeSource("Freelance Work");

        budgetSystem.UpdateBudgetBalance(6000, 3000);

        string report = budgetSystem.GenerateBasicReport();
        userInterface.DisplayBudgetReport(report);

        dataStorage.SaveBudgetData(report);
    }
}