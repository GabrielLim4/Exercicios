using System;

decimal valorDesconto = 0, valorFinal = 0, valorVeiculo, porcentagemVeiculo;
int anoVeiculo, totalCarrosAteAno2000 = 0, totalCarros = 0;
string desejaContinuar = "S";

while (desejaContinuar == "S" || desejaContinuar == "s")
{
    Console.WriteLine("Digite o valor do veículo:");
    valorVeiculo = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o ano de fabricação do veículo:");
    anoVeiculo = Convert.ToInt32(Console.ReadLine());

    if (anoVeiculo <= 2000)
    {
        porcentagemVeiculo = 0.12M;
        totalCarrosAteAno2000++;
    }
    else
    {
        porcentagemVeiculo = 0.07M;
    }

    totalCarros++;

    valorDesconto = valorVeiculo * porcentagemVeiculo;
    valorFinal = valorVeiculo - valorDesconto;

    Console.WriteLine($"O valor do desconto foi de {valorDesconto.ToString("C2")}");
    Console.WriteLine($"Valor a ser pago pelo cliente: {valorFinal.ToString("C2")}");

    Console.WriteLine("Deseja Continuar? (S) - Sim, (N) - Não");
    desejaContinuar = Console.ReadLine();
}

Console.WriteLine($"Total de carros: {totalCarros}");
Console.WriteLine($"Total de carros até o ano 2000: {totalCarrosAteAno2000}");