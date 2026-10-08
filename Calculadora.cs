try
{
List<decimal> typedNumbers = new List<decimal>();
bool running = true;

Console.WriteLine("<=== STUDENT SYSTEM ===>");

while (running)
{
Console.WriteLine("1. Calculator");
Console.WriteLine("2. Student Grades");
Console.WriteLine("3. Close");

Console.WriteLine("Enter your option: ");  
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
 {
    case 1:
        Console.WriteLine("<=== CALCULATOR ===>");

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Back to Main menu");

        Console.WriteLine("Enter your option: ");
        int calcOption = Convert.ToInt32(Console.ReadLine());

        switch (calcOption)
        {  
            case 1: 
            console.WriteLine("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine($"Result: {num1 + num2}");
            break;

            case 2:
            console.WriteLine("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine($"Result: {num1 - num2}");
            break;

            case 3:
            console.WriteLine("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Result: {num1 * num2}");
            break;

            case 4:
            console.WriteLine("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            console.WriteLine($"Result: {num1 / num2}");
            break;

            case 5:
            break;
        }

    break; 

    case 2:
        Console.WriteLine("<=== STUDENT GRADES ===>");

        Console.Write("Enter the first grade: ");
        decimal grade1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter the second grade: ");
        decimal grade2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter the third grade: ");
        decimal grade3 = Convert.ToDecimal(Console.ReadLine());

        decimal average = (grade1 + grade2 + grade3) / 3;
        Console.WriteLine("Average: " + average);

        String results = average >= 70 ? "approved" : "failed";
        Console.WriteLine("The student is " + results);
    break;

    case 3:
        running = false;
        Console.WriteLine("Close the program");
    break;
 }
}
}