Console.WriteLine("Welcome to the ConsoleApp Calculator!");
double num1;
double num2;
string operation;
while (true)
{
    while (true)
    {
        Console.WriteLine("Enter the first number:");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Clear(); // konsol
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        } break;
    }Console.Clear(); // konsol temiz
    
    while (true)
    {
        Console.WriteLine("Enter the operation:\n + (plus)\n - (minus)\n * (multiply)\n / (divided)");
        operation = Console.ReadLine();
        if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.Clear();  // temiz konsol 
            Console.WriteLine("Please enter valid operations");
            continue;
        }
        break;
    }
    while (true)
    {
        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Clear(); // konsol
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        } break;
    }Console.Clear(); // konsol temiz
    
    if (operation == "+")
    {
        Console.WriteLine($"The result is: {num1 + num2}");
    }
    else if (operation == "-")
    {
        Console.WriteLine($"The result is: {num1 - num2}");
    }
    else if (operation == "*")
    {
        Console.WriteLine($"The result is: {num1 * num2}");
    }
    else if (operation == "/")
    {
        if (num2 == 0)
        {
            Console.Clear();  // temiz konsol
            Console.WriteLine("Error: Division by zero is not allowed.");
            continue;
        }
        Console.WriteLine($"The result is: {num1 / num2}");
    }
    
    while (true)
    {
        Console.WriteLine("Do you want to enter another operation? (y/n)");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y" || answer == "yes" || answer == "ye" || answer == "yess"
            || answer == "yep" || answer == "yeah" || answer == "he" || answer == "hee")
        {
            Console.Clear();
            Console.WriteLine("You chose another operation.");
        }
        else if (answer == "n" || answer == "no" || answer == "nope" || answer == "nah" 
                 || answer == "nao"  || answer == "yox" || answer == "yo")
        {
            Console.Clear();
            Console.WriteLine("Goodbye :("); 
            Environment.Exit(0); // prgram baglamag ucun 
        }
        else 
        {
            Console.Clear();  // temiz konsol
            Console.WriteLine("Please enter valid operations (y/n)");
            continue;
        }
        break;
    }
}

    





