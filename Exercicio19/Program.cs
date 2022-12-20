using System;

string nome, sexo;
int countM = 0, countF = 0;

for (int i = 0; i < 56; i++)
{
    Console.WriteLine("Digite o Nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o Sexo(M - Masculino, F - Feminino): ");
    sexo = Console.ReadLine();

    if (sexo == "M" || sexo == "m")
    {
        Console.WriteLine($"Nome: {nome} \n" +
                          $"Sexo: Masculino");
        Console.WriteLine("---------------------");
        countM++;
    }
    else if (sexo == "F" || sexo == "f")
    {
        Console.WriteLine($"Nome: {nome} \n" +
                          $"Sexo: Feminino");
        Console.WriteLine("---------------------");
        countF++;
    }
    else
    {
        Console.WriteLine("Entrada Inválida.");
        Console.WriteLine("---------------------");
    }
    
}

Console.WriteLine($"Total de Homens: {countM}");
Console.WriteLine($"Total de Mulheres: {countF}");