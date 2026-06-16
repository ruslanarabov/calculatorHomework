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
        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out num2))
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
        else if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.Clear();  // temiz konsol 
            Console.WriteLine("Please enter valid operations");
            continue;
        }
        break;
    }

    // Console.WriteLine("Press any key to continue...");
    // Console.ReadKey();
    // Console.Clear();
    
}
    





