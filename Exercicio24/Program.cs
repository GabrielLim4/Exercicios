using System;

int numero;
string desejaContinuar = "s";

while (desejaContinuar == "S" || desejaContinuar == "s")
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine("POSITIVO");
    }
    else if (numero == 0)
    {
        Console.WriteLine("O NÚMERO É ZERO");
    }
    else
    {
        Console.WriteLine("NEGATIVO");
    }

    Console.WriteLine("Deseja Continuar? (S) - Sim  (N) - Não");
    desejaContinuar = Console.ReadLine();
}