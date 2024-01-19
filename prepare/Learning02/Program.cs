using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World! ");
        Console.WriteLine("");
        Console.WriteLine("What is your full name?");
        string full_name = Console.ReadLine();
        Console.WriteLine("How old are you? ");
        string age = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Tell me about yourself");
        Console.WriteLine ("Did you ever have a Job?");
        Console.WriteLine ("Please answear <Yes> or <No>");
        string answear1 = Console.ReadLine();
        if (answear1 == "Yes")
        {
            Console.WriteLine("What Job did you do?");
            Console.WriteLine("Name the title of the Job you had: ");
            string jobTitle1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine ("Name the company you worked on: ");
            string company1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What year did you started working there?");
            string startYear1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("What year did you finished working there");
            string endYear1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Did you had any other Job? ");
            Console.WriteLine("Please answear <Yes> or <No>");
            string answear2 = Console.ReadLine();
            if (answear2 == "Yes")
            {
                Console.WriteLine("What Job did you do?");
                Console.WriteLine("Name the title of the Job you had: ");
                string jobTitle2 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine ("Name the company you worked on: ");
                string company2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("What year did you started working there?");
                string startYear2 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("What year did you finished working there");
                string endYear2 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("That is all i'll ask of your expiriences");
                Console.WriteLine("Thank you! ");
                Console.WriteLine("");
                Console.WriteLine($"Name: {full_name} ({age})");
                Console.WriteLine("Job Expirience: ");
                Console.WriteLine($"{jobTitle1} ({company1}) {startYear1}-{endYear1}");
                Console.WriteLine($"{jobTitle2} ({company2}) {startYear2}-{endYear2}");
            }
            else if(answear2 == "No")
            {
                Console.WriteLine("Volunteering and training count as expirience");
                Console.WriteLine("Did you do any volunteering or training?");
                Console.WriteLine("Please answear <Yes> or <No>");
                string answear3 = Console.ReadLine();
                if (answear3 == "Yes")
                {
                    Console.WriteLine("Please tell me: ");
                    Console.WriteLine("Did you do a volunteering or training?");
                    Console.WriteLine("Please answear <Volunteering> or <Training>");
                    string option1 = Console.ReadLine();
                    if (option1 == "Volunteering")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("What position did you volunteer for? ");
                        string jobTitle2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Name the company you volunteer for: ");
                        string company2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("What year did your volunteering started? ");
                        string startYear2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("What year did your volunteering ended? ");
                        string endYear2 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("That is all i'll ask of your expiriences");
                        Console.WriteLine("Thank you! ");
                        Console.WriteLine("");
                        Console.WriteLine($"Name: {full_name} ({age})");
                        Console.WriteLine("Job Expirience: ");
                        Console.WriteLine($"{jobTitle1} ({company1}) {startYear1}-{endYear2}");
                        Console.WriteLine($"{jobTitle2} Volunteer ({company2}) {startYear2}-{endYear2}");
                    }
                    else if (option1 == "Training")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("What position did you train for? ");
                        string jobTitle2 = Console.ReadLine();
                        Console.WriteLine ("");
                        Console.WriteLine("Name the company you trained for: ");
                        string company2 = Console.ReadLine();
                        Console.WriteLine("What year did you do your training?");
                        string startYear2 = Console.ReadLine();
                        Console.WriteLine("That is all i'll ask of your expiriences");
                        Console.WriteLine("Thank you! ");
                        Console.WriteLine("");
                        Console.WriteLine($"Name: {full_name} ({age})");
                        Console.WriteLine("Job Expirience");
                        Console.WriteLine($"{jobTitle1} ({company1}) {startYear1}-{endYear1}");
                        Console.WriteLine($"{jobTitle2} in training ({company2}) {startYear2}-{startYear2}");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("The option you wrote doesn't exist");
                    }
            }
            
        }
        else if(answear1 == "No")
        {
            Console.WriteLine("Volunteering and training count as expieience");
            Console.WriteLine("Did you do any volunteering or training?");
            Console.WriteLine("Please answear <Yes> or <No>");
            string answear3 = Console.ReadLine();
                if (answear3 == "Yes")
                {
                    Console.WriteLine("Please tell me: ");
                    Console.WriteLine("Did you do a volunteering or training?");
                    Console.WriteLine("Please answear <Volunteering> or <Training>");
                    string option1 = Console.ReadLine();
                        if (option1 == "Volunteering")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("What position did you volunteer for? ");
                            string jobTitle2 = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Name the company you volunteer for: ");
                            string company2 = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("What year did your volunteering started? ");
                            string startYear2 = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("What year did your volunteering ended? ");
                            string endYear2 = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("That is all i'll ask of your expiriences");
                            Console.WriteLine("Thank you! ");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {full_name} ({age})");
                            Console.WriteLine("Job Expirience: ");
                            Console.WriteLine($"{jobTitle2} volunteer ({company2}) {startYear2}-{endYear2}");
                        }
                        else if (option1 == "Training")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("What position did you train for? ");
                            string jobTitle2 = Console.ReadLine();
                            Console.WriteLine ("");
                            Console.WriteLine("Name the company you trained for: ");
                            string company2 = Console.ReadLine();
                            Console.WriteLine("What year did you do your training?");
                            string startYear2 = Console.ReadLine();
                            Console.WriteLine("That is all i'll ask of your expiriences");
                            Console.WriteLine("Thank you! ");
                            Console.WriteLine("");
                            Console.WriteLine($"Name: {full_name} ({age})");
                            Console.WriteLine("Job Expirience");
                            Console.WriteLine($"{jobTitle2} in training ({company2}) {startYear2}-{startYear2}");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("The option you wrote doesn't exist");
                        }
                }
                else if(answear3 == "No")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Then i will not ask anything else of your expiriences");
                    Console.WriteLine("Thank you");
                    Console.WriteLine("");
                    Console.WriteLine($"Name: {full_name} ({age})");
                    Console.WriteLine("Job Expirience: ");
                    Console.WriteLine("(No Job Expirience)");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The option you wrote doesn't exist");
                }

        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("The option you wrote doesn't exist");
        }
        }
    }
}