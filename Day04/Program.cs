// int[] marks = [85, 90, 78, 92, 88];

// Console.WriteLine(string.Join(", ", marks));


// int total = 0;
// Array.ForEach(marks, (int mark) =>
// {
//     total += mark;
//     Console.WriteLine(total);
// });

// double average = (double)total / marks.Length;
// Console.WriteLine(average);

// int highest = marks.Max();
// Console.WriteLine(highest);

// int lowest = marks.Min();
// Console.WriteLine(lowest);

// int[] marksAbove85 = marks.Where(m => m > 85).ToArray();
// Console.WriteLine(string.Join(", ", marksAbove85));


// List<string> tasks = new List<string> { "Learn C#", "Practice arrays", "Build API" };
// tasks.Add("Learn lists");

// tasks.Insert(3, "Revise loops");

// tasks[2] = "Build .NET API";

// bool containsTask = tasks.Contains("Learn C#");
// Console.WriteLine(containsTask);

// tasks.Remove("Practice arrays");
// Console.WriteLine(tasks.Count);

// tasks.ForEach( task => Console.WriteLine(task));

// Dictionary<int, string> students = new()
// {
//     { 101, "Akhtar" },
//     { 102, "Sara" },
//     { 103, "Rahul" }
// };

// students.Add(104, "Aisha");

// students[102] = "Sara Khan";

// Console.WriteLine(students.TryGetValue(103, out string? name));
// students.ToList().ForEach(student => Console.WriteLine($"ID: {student.Key}, Name: {student.Value}"));



// Student management system

// 1. Collections Setup

Dictionary<int, string> studentDict = new Dictionary<int, string>();
List<string> studentList = new List<string>();
HashSet<string> uniqueNamesSet = new HashSet<string>();

// Fixed-size sample marks array for statistics
int[] sampleMarks = { 85, 92, 78, 90, 65, 88, 95 };

bool running = true;

while (running)
{
    Console.WriteLine("\nStudent Record Manager");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Search Student");
    Console.WriteLine("3. Update Student");
    Console.WriteLine("4. List Students");
    Console.WriteLine("5. Delete Student");
    Console.WriteLine("6. Count Students");
    Console.WriteLine("7. Show Sample Marks Statistics");
    Console.WriteLine("8. Exit");
    Console.Write("\nChoose an option: ");

    // Input validation for menu choice
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.Write("Enter Student ID (numeric): ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Error: ID must be a valid number.");
                break;
            }

            if (studentDict.ContainsKey(id))
            {
                Console.WriteLine("Error: A student with this ID already exists.");
                break;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Name cannot be empty or whitespace.");
                break;
            }
            studentDict.Add(id, name);
            studentList.Add(name);
            uniqueNamesSet.Add(name);

            Console.WriteLine($"Success: Student '{name}' added with ID {id}.");
            break;

        case 2:
            if (studentDict.Count == 0)
            {
                Console.WriteLine("No student records exist yet.");
                break;
            }

            Console.Write("Enter Student ID to search: ");
            if (!int.TryParse(Console.ReadLine(), out int searchId))
            {
                Console.WriteLine("Error: Invalid ID format.");
                break;
            }

            if (studentDict.TryGetValue(searchId, out string foundName))
            {
                Console.WriteLine($"Found! ID: {searchId} | Name: {foundName}");
            }
            else
            {
                Console.WriteLine("Student with this ID was not found.");
            }
            break;

        case 3:
            if (studentDict.Count == 0)
            {
                Console.WriteLine("No student records exist to update.");
                break;
            }

            Console.Write("Enter Student ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int updateId))
            {
                Console.WriteLine("Error: Invalid ID format.");
                break;
            }

            if (!studentDict.ContainsKey(updateId))
            {
                Console.WriteLine("Error: Student ID does not exist.");
                break;
            }

            Console.Write("Enter new student name: ");
            string newName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                break;
            }

            string oldName = studentDict[updateId];
            studentDict[updateId] = newName;
            studentList.Remove(oldName);
            studentList.Add(newName);
            uniqueNamesSet.Add(newName);

            Console.WriteLine($"Success: Student ID {updateId} updated to '{newName}'.");
            break;

        case 4:
            if (studentDict.Count == 0)
            {
                Console.WriteLine("No students registered in the system.");
                break;
            }

            Console.WriteLine("Registered Students");
            foreach (var student in studentDict)
            {
                Console.WriteLine($"ID: {student.Key} | Name: {student.Value}");
            }
            break;

        case 5:
            if (studentDict.Count == 0)
            {
                Console.WriteLine("No student records to delete.");
                break;
            }

            Console.Write("Enter Student ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int deleteId))
            {
                Console.WriteLine("Error: Invalid ID format.");
                break;
            }

            if (studentDict.TryGetValue(deleteId, out string deletedName))
            {
                studentDict.Remove(deleteId);
                studentList.Remove(deletedName);

                Console.WriteLine($"Success: Student ID {deleteId} ('{deletedName}') was removed.");
            }
            else
            {
                Console.WriteLine("Error: Student ID not found.");
            }
            break;

        case 6:
            // FR-06: Count Students
            Console.WriteLine($"Total registered students: {studentDict.Count}");
            Console.WriteLine($"Unique names registered: {uniqueNamesSet.Count}");
            break;

        case 7:
            // Show Sample Marks Statistics (using int[])
            Console.WriteLine("\n--- Sample Marks Statistics ---");
            Console.WriteLine($"Sample Marks: {string.Join(", ", sampleMarks)}");

            int total = 0;
            int highest = sampleMarks[0];
            int lowest = sampleMarks[0];

            foreach (int mark in sampleMarks)
            {
                total += mark;
                if (mark > highest) highest = mark;
                if (mark < lowest) lowest = mark;
            }

            double average = (double)total / sampleMarks.Length;

            Console.WriteLine($"Total Score: {total}");
            Console.WriteLine($"Average Score: {average:F2}");
            Console.WriteLine($"Highest Mark: {highest}");
            Console.WriteLine($"Lowest Mark: {lowest}");
            break;

        case 8:
            
            running = false;
            Console.WriteLine("Exiting program. Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice. Please choose an option between 1 and 8.");
            continue;
    }
}