bool exit = false;
while (!exit)
{
    ShowMenu();

    Console.Write("Enter your choice (1-5): ");
    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        continue;
    }

    if (choice == 5)
    {
        Console.WriteLine("Exiting the calculator. Goodbye!");
        exit = true;
        continue;
    }

    Console.Write("Enter the first number: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    Console.Write("Enter the second number: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    PerformOperation(choice, num1, num2);
}
static void ShowMenu()
{
    Console.WriteLine("\n=== Calculator ===");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
}

static void PerformOperation(int choice, double num1, double num2)
{
    double result = 0;
    switch (choice)
    {
        case 1:
            result = Add(num1, num2);
            Console.WriteLine($"Result: {num1} + {num2} = {result}");
            break;
        case 2:
            result = Subtract(num1, num2);
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            break;
        case 3:
            result = Multiply(num1, num2);
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            break;
        case 4:
            try
            {
                result = Divide(num1, num2);
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
}

static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    return a / b;
}