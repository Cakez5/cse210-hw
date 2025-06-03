using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static List<Scripture> scriptures = new List<Scripture>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== Scripture Helper =====");
            Console.WriteLine("1. Enter a new scripture");
            Console.WriteLine("2. Start memorization challenge");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EnterScripture();
                    break;
                case "2":
                    StartMemorizationChallenge();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void EnterScripture()
    {
        Console.Clear();
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the verse(s): ");
        string verseInput = Console.ReadLine();
        int verse, endVerse;
        string[] verses = verseInput.Split('-');

        if (verses.Length == 2)
        {
            verse = int.Parse(verses[0]);
            endVerse = int.Parse(verses[1]);
        }
        else
        {
            verse = int.Parse(verses[0]);
            endVerse = verse;
        }

        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);
        scriptures.Add(scripture);

        Console.WriteLine("\nScripture saved! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void StartMemorizationChallenge()
    {
        Console.Clear();
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available. Please enter one first.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Choose a scripture:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}");
        }

        Console.Write("Enter the number of the scripture: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= scriptures.Count)
        {
            Console.WriteLine("Invalid choice. Press Enter to return to the menu.");
            Console.ReadLine();
            return;
        }

        Scripture scripture = scriptures[choice];
        Stopwatch stopwatch = new Stopwatch();

        while (true)
        {
            stopwatch.Restart();
            Console.Clear();
            Console.WriteLine("Memorization challenge starting...");
            Console.WriteLine(scripture.GetDisplayText());

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words...");
                Console.ReadLine();
                scripture.HideRandomWords(2);
            }

            stopwatch.Stop();
            Console.WriteLine("\nAll words are hidden!");
            Console.WriteLine($"Total time taken: {stopwatch.Elapsed.TotalSeconds} seconds");

            Console.WriteLine("\nWould you like to try again for a better time? (Y/N)");
            string retry = Console.ReadLine().ToLower();
            if (retry != "y") break;

            // Reset scripture for retry
            scripture = new Scripture(scripture.Reference, scripture.GetDisplayText().Replace("_____", ""));
        }
    }
}