using System;

int numero;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 80 || numero < 25 || numero == 40) 
{
    Console.WriteLine("ACERTOU!");
}
else
{ 
    Console.WriteLine("ERROU!");
}