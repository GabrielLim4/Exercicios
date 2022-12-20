using System;

double nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
nota3 = Convert.ToDouble(Console.ReadLine());


media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)
{
    Console.WriteLine($"Média: {media.ToString("N2")} - Aprovado!");
}
else if (media >= 5.1 && media <= 6.9)
{
    Console.WriteLine($"Média: {media.ToString("N2")} - Recuperação.");
}
else
{
    Console.WriteLine($"Média: {media.ToString("N2")} - Reprovado.");
}