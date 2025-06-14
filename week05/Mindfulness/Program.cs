class Program
{
    static void Main()
    {
        string choice = "";
        Journal journal = new Journal();

        while (choice != "5")
        {
            Console.WriteLine("\nMindfulness Tracker");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity(30).Run();
                    break;
                case "2":
                    new ListingActivity(30).Run();
                    break;
                case "3":
                    new ReflectingActivity(30).Run();
                    break;
                case "4":
                    Console.WriteLine("1. Add Entry\n2. View Entries");
                    string journalChoice = Console.ReadLine();
                    if (journalChoice == "1")
                        journal.AddEntry();
                    else if (journalChoice == "2")
                        journal.ViewEntries();
                    else
                        Console.WriteLine("Invalid journal option.");
                    break;
                case "5":
                    Console.WriteLine("Goodbye! Keep up the good habits. ✨");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1–5.");
                    break;
            }
        }
    }
}