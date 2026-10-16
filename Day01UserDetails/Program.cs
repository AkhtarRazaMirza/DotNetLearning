// // See https://aka.ms/new-console-template for more information
// string name = "akhtar";
// int age = 25;
// double height = 6.2222;
// bool isStudent = true;
// Console.WriteLine("Hello, " + name + "! You are " + age + " years old and your height is " + height + ". Are you a student? " + isStudent);
// Console.WriteLine($"Hello, I am {name}, I am {age} years old and my height is {height}. Am I a student? {isStudent}");


// int a = 10;
// int b = 5;

// Console.WriteLine(a + b); // 15
// Console.WriteLine(a - b); // 5
// Console.WriteLine(a * b); // 50
// Console.WriteLine(a / b); // 2
// Console.WriteLine(a % b); // 0

// Console.Write("Enter your name: ");
// string userName = Console.ReadLine() ?? "";

// Console.Write("Enter your age: ");
// string ageInput = Console.ReadLine() ?? "";

// Console.WriteLine($"Hello, {userName}!");
// Console.WriteLine($"Your age is {ageInput}.");


// Console.WriteLine("=== My Profile ===");

// Console.Write("Enter your name: ");
// string inputName = Console.ReadLine() ?? "";

// Console.Write("Enter your age: ");
// string inputAge = Console.ReadLine() ?? "";

// Console.Write("Enter your city: ");
// string inputCity = Console.ReadLine() ?? "";

// // TODO: Ask for daily study hours and store the input.
// Console.Write("Enter your daily study hours: ");
// string inputStudyHours = Console.ReadLine() ?? "";

// Console.WriteLine("\n=== Profile Summary ===");

// // TODO: Print name, age, city, and daily study hours.
// Console.WriteLine($"Name: {inputName}");
// Console.WriteLine($"Age: {inputAge}");
// Console.WriteLine($"City: {inputCity}");
// Console.WriteLine($"Daily Study Hours: {inputStudyHours}");



Console.WriteLine("=== Basic Calculator ===");

Console.Write("Enter first number: ");
if (!double.TryParse(Console.ReadLine(), out double first))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

Console.Write("Enter second number: ");
if (!double.TryParse(Console.ReadLine(), out double second))
{
    Console.WriteLine("Please enter a valid number.");
    return;
}

Console.Write("Choose operation (+, -, *, /): ");
string operation = Console.ReadLine() ?? "";

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {first + second}");
        break;
    case "-":
        Console.WriteLine($"Result: {first - second}");
        break;
    case "*":
        Console.WriteLine($"Result: {first * second}");
        break;
    case "/":
        if (second == 0)
            Console.WriteLine("Cannot divide by zero.");
        else
            Console.WriteLine($"Result: {first / second}");
        break;
    default:
        Console.WriteLine("Invalid operation.");
        break;
}
