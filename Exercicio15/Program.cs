using System;

int numero;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 100 && numero <= 200)
{
    Console.WriteLine("Esse número está no intervalo de 100 e 200.");
}
else
{
    Console.WriteLine("Esse número não está no intervalo de 100 e 200.");
}