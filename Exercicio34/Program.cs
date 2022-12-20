using System;


Console.WriteLine("Digite a idade do(a) nadador(a): ");
int idade = Convert.ToInt32(Console.ReadLine());


if (idade >= 5 && idade <= 7)
{
    Console.WriteLine("Infantil A");
}
else if (idade >= 8 && idade <= 10)
{
    Console.WriteLine("Infantil B");
}
else if (idade >= 11 && idade <= 13)
{
    Console.WriteLine("Juvenil A");
}
else if (idade >= 14 && idade <= 17)
{
    Console.WriteLine("Juvenil B");
}
else if (idade >= 18 && idade <= 25)
{
    Console.WriteLine("Sênior");
}
else
{
    Console.WriteLine("Idade fora da faixa etária");
}