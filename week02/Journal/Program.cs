using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string filename = "journal.txt";

        while (true)
        {
            Console.WriteLine("Welcome to Easy Journals!");
            Console.Write("Options ");
            Console.WriteLine("\n1. Write Entry  \n2. Display Entries  \n3. Save  \n4. Load  \n5. Exit");
            Console.Write("What would you like to chose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile(filename);
                    Console.WriteLine("Journal saved!");
                    break;
                case "4":
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded!");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}