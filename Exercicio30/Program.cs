using System;

int a, b, c;

Console.WriteLine("Digite o primeiro valor: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o primeiro valor: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o primeiro valor: ");
c = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    if (a < c)
    {
        Console.WriteLine($"{a} {b} {c}");
    }
    else if (c < b)
    {
        Console.WriteLine($"{c} {a} {b}");
    }
    else if (b < c)
    {
        Console.WriteLine($"{a} {c} {b}");
    }
}
else
{
    if (b < c)
    {
        Console.WriteLine($"{a} {b} {c}");
    }
    else if (c < a)
    {
        Console.WriteLine($"{b} {c} {a}");
    }
    else
    {
        Console.WriteLine($"{b} {a} {c}");
    }
}