using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to the Number Guess Game!");
        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(1, 101);
     
        int guess = -1;

        while (guess != RandomNumber)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (RandomNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (RandomNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain == "yes")
        {
            RandomNumber = randomGenerator.Next(1, 101); // Generate a new number
            guess = -1; // Reset guess
        }
            else
        {
            break; // Exit the loop
        }
        }
        }
    }
}