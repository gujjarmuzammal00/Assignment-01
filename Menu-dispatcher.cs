using System; // Needed for Console.ReadLine and Console.WriteLine

Console.WriteLine("=== Main Menu ===");
Console.WriteLine("1. View Account Details");
Console.WriteLine("2. Make a Deposit");
Console.WriteLine("3. Withdraw Funds");
Console.WriteLine("4. Transfer Money");
Console.WriteLine("5. View Transaction History");
//ask for input once
Console.Write("Select an option (1-5): ");
string input = Console.ReadLine(); // Read user input

// Switch-case acts as dispatcher
switch (input)
{
    case "1":
        Console.WriteLine("Action 1: Viewing account details...");
        break;
    case "2":
        Console.WriteLine("Action 2: Making a deposit...");
        break;
    case "3":
        Console.WriteLine("Action 3: Withdrawing funds...");
        break;
    case "4":
        Console.WriteLine("Action 4: Transferring money...");
        break;
    case "5":
        Console.WriteLine("Action 5: Viewing transaction history...");
        break;
    default:
        Console.WriteLine("Invalid selection. Please choose a valid option.");
        break;
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();