// See https://aka.ms/new-console-template for more information
double a;
double b;
double c;

Console.Write("Write first number: ");
a = double.Parse(Console.ReadLine());
Console.Write("Write second number: ");
b = double.Parse(Console.ReadLine());

Console.Write("Write operator: ");
char operat = char.Parse(Console.ReadLine());

switch (operat)
{
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
        c = a / b;
        Console.WriteLine(c);
        break;
}
