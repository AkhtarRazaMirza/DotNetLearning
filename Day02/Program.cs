// Build a menu-driven calculator

// bool running = true;

// while (running)
// {
//     Console.WriteLine(" C# Calculator ");
//     Console.WriteLine("1. Addition");
//     Console.WriteLine("2. Subtraction");
//     Console.WriteLine("3. Multiplication");
//     Console.WriteLine("4. Division");
//     Console.WriteLine("5. Exit");
//     Console.Write("Choose an option: ");

//     string? choice = Console.ReadLine();

//     if (choice == "5")
//     {
//         running = false;
//         Console.WriteLine("Calculator closed.");
//         continue;
//     }

//     if (choice != "1" && choice != "2" &&
//         choice != "3" && choice != "4")
//     {
//         Console.WriteLine("Invalid choice. Try again.");
//         continue;
//     }

//     Console.Write("Enter first number: ");
//     if (!double.TryParse(Console.ReadLine(), out double a))
//     {
//         Console.WriteLine("Invalid first number.");
//         continue;
//     }

//     Console.Write("Enter second number: ");
//     if (!double.TryParse(Console.ReadLine(), out double b))
//     {
//         Console.WriteLine("Invalid second number.");
//         continue;
//     }

//     switch (choice)
//     {
//         case "1":
//             Console.WriteLine($"Result: {a + b}");
//             break;

//         case "2":
//             Console.WriteLine($"Result: {a - b}");
//             break;

//         case "3":
//             Console.WriteLine($"Result: {a * b}");
//             break;

//         case "4":
//             if (b != 0)
//             {
//                 Console.WriteLine($"Result: {a / b}");
//             }
//             else
//             {
//                 Console.WriteLine("Cannot divide by zero.");
//             }
//             break;
//     }
// }




// Multiplication-table generator

bool running = true;

while (running)
{
    Console.WriteLine(" Multiplication Table Generator ");  
    Console.WriteLine("Enter 0 to exit.");
    Console.Write("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number == 0)
        {
            running = false;
            Console.WriteLine("Exiting multiplication table generator.");
            break;
        }
        else
        {
            Console.Write("Enter last multiplier: ");
            if (!int.TryParse(Console.ReadLine(), out int lastMultiplier) || lastMultiplier <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the last multiplier.");
                continue;
            }
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= lastMultiplier; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid integer.");
        continue;
    }
}