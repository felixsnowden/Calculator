double c = 0;

Console.Write("Write first number: ");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("This is not a number!");
    return;
}
Console.Write("Write second number: ");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("This is not a number!");
    return;
}

Console.Write("Write operator: ");
char operat = Console.ReadLine()[0];

switch (operat)
{
    default:
        Console.WriteLine("Unknown operator");
        break;
    case '*':
        c = a * b;
        Console.WriteLine(c);
        break;
    case '+':
        c = a + b;
        Console.WriteLine(c);
        break;
    case '-':
        c = a - b;
        Console.WriteLine(c);
        break;
    case '/':
        if (b == 0)
        {
            Console.WriteLine("Cannot be divided by 0");
        }
        else
        {
            c = a / b;
            Console.WriteLine(c);
        }
        break;
}
