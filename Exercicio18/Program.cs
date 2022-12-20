using System;

int idade = 0;

for (int i = 0; i < 75; i++)
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine("Maior de Idade.");
        Console.WriteLine("-----------------");
    }
    else
    {
        Console.WriteLine("Menor de Idade.");
        Console.WriteLine("-----------------");
    }
}