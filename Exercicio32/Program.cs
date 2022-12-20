using System;

int a, b, c;

Console.WriteLine("Digite o primeiro valor: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor: ");
c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    if (a == b && b == c)
    {
    Console.WriteLine("TRIANGULO EQUILÁTERO");
    }
    else if (a == b || b == c || a == c) 
    {
        Console.WriteLine("TRIANGULO ISÓSCELE");
    }
    else
    {
        Console.WriteLine("TRIANGULO ESCALENO");
    }
} 
else 
{
    Console.WriteLine("Os números informados não podem formar lados de um triângulo");
}