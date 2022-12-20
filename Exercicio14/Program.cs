using System;

int numero1, numero2;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());


if (numero1 > numero2)
{
    Console.WriteLine($"O primeiro número é maior que o segundo. \n" + 
                      $"Primeiro número: {numero1} \n" + 
                      $"Segundo número: {numero2}");
} 

else if (numero1 == numero2)
{
    Console.WriteLine($"Os número são iguais. \n" + 
                      $"Primeiro número: {numero1} \n" + 
                      $"Segundo número: {numero2}");
} 

else
{
    Console.WriteLine($"O segundo número é maior que o primeiro. \n" + 
                      $"Primeiro número: {numero1} \n" + 
                      $"Segundo número: {numero2}");
}