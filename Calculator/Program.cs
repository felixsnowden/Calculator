double a;
double b;
double c;

Console.Write("Write first number: ");
a = double.Parse(Console.ReadLine());
Console.Write("Write second number: ");
b = double.Parse(Console.ReadLine());

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
