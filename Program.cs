using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Pulse CLI! Type 'help' for a list of commands or 'exit' to quit.");

        while (true)
        {
            Console.Write("> "); // Show a prompt
            string input = Console.ReadLine()?.Trim(); // Read user input

            if (string.IsNullOrEmpty(input))
                continue;

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting Pulse CLI. Goodbye!");
                Environment.Exit(0); // Close the application immediately
            }

            HandleCommand(input);
        }
    }

    static void HandleCommand(string input)
    {
        switch (input.ToLower())
        {
            case "pl help":
                ShowHelp();
                break;
            case "pl sum-keys":
                Console.WriteLine("Fetching all keys...");
                break;
            case "pl sum-keys --force":
                Console.WriteLine("Regenerating all keys...");
                break;
            default:
                Console.WriteLine($"{input} is an unkown command");
                ShowHelp();
                break;
        }
    }

    static void ShowHelp()
    {
        Console.WriteLine("Pulse CLI Help:");
        Console.WriteLine("1. help                - Show this help menu.");
        Console.WriteLine("2. sum-keys            - Fetch API keys for your project.");
        Console.WriteLine("3. sum-keys --force    - Regenerate all API keys.");
        Console.WriteLine("\nType 'exit' to quit the CLI.");
    }
}
