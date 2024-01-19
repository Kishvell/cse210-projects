using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
                {
            PlayGuessMyNumber();
        }

        static void PlayGuessMyNumber()
        {
            string playAgain = "yes";
            Random random = new Random();

            while (playAgain.ToLower() == "yes")
            {
                int magicNumber = random.Next(1, 101);
                int guess;
                int guesses = 0;

                do
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guesses++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                } while (guess != magicNumber);

                Console.WriteLine($"It took you {guesses} guesses.");
                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine();
            }
        }
    }
}