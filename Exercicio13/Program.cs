using System;

int numero;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 10)
{
    Console.WriteLine($"{numero}. Esse número é maior que 10!");
}
else
{
    Console.WriteLine(numero);
}