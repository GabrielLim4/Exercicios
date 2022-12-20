using System;

// int numero;

Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("UM");
        break;
    case 2:
        Console.WriteLine("DOIS");
        break;
    case 3:
        Console.WriteLine("TRÊS");
        break;
    case 4:
        Console.WriteLine("QUATRO");
        break;
    case 5:
        Console.WriteLine("CINCO");
        break;
    default:
        Console.WriteLine("Número Inválido");
        break;
}