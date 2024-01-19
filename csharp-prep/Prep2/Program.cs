using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string passMessage;
        if (gradePercentage >= 70)
        {
            passMessage = "Congratulations! You passed the course.";
        }
        else
        {
            passMessage = "You did not pass the course. Better luck next time!";
        }

        Console.WriteLine("Your letter grade is: " + letter);

        Console.WriteLine(passMessage);

        int lastDigit = Convert.ToInt32(gradePercentage.ToString().Substring(gradePercentage.ToString().Length - 1));
        string sign = "";
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter == "F" && lastDigit < 3)
        {
            sign = "";
        }
        else
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        Console.WriteLine("Your final grade is: " + letter + sign);
    }
}