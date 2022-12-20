using System;

int numero = 0;
int cont = 0;

for (int i = 0; i < 80; i++)
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    
    if (numero >= 10 && numero <= 150)
    {
        cont++;
    }
}

Console.WriteLine($"Números entre 10 e 150: {cont}");