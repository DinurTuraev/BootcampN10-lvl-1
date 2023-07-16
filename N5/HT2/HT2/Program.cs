char command;
do
{
    Console.WriteLine("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter command: ");
    command = Convert.ToChar(Console.ReadLine());
    
    Console.WriteLine("Enter a second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (command == '+')
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }
    else if (command == '-')
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }
    else if (command == '*')
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
    }
    else if (command == '/')
    {
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }
} while (command != 'e');










