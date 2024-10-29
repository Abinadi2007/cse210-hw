using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Search entries by text");
            Console.WriteLine("4. Search entries by date");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Enter the text for your journal entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(entryText);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    Console.WriteLine("\nDisplaying all journal entries:");
                    myJournal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter text to search for: ");
                    string searchText = Console.ReadLine();
                    myJournal.SearchEntriesByText(searchText);
                    break;


                case "4":
                    Console.Write("Enter the date to search for (YYYY-MM-DD): ");
                    DateTime searchDate = DateTime.Parse(Console.ReadLine());
                    myJournal.SearchEntriesByDate(searchDate);
                    break;


                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}