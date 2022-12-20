using System;

int numero1, numero2;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());


if (numero1 == numero2)
{
    Console.WriteLine("Os números são iguais");
}
else if (numero1 > numero2)
{
    Console.WriteLine("Os números são diferentes. O primeiro número é maior que o segundo.");
}
else
{
    Console.WriteLine("Os números são diferentes. O segundo número é maior que o prmeiro.");
}