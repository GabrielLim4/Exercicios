using System;

int a, b;
char c;

Console.WriteLine("Digite o primeiro valor: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o operador aritmético: ");
c = Convert.ToChar(Console.ReadLine());

if (c == '+')
{
    Console.WriteLine(a + b);
}
else if (c == '-')
{
    Console.WriteLine(a - b);
}
else if (c == '*')
{
    Console.WriteLine(a * b);
}
else if (c == '/')
{
    if (b == 0)
    {
        Console.WriteLine("Divisão por zero não é permitida.");
    }
    else
    {
        Console.WriteLine(a / b);
    }
}
else
{
    Console.WriteLine("Operador inválido.");
}

