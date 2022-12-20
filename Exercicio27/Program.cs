using System;

decimal porcentagem = 0;


Console.WriteLine("Digite o valor do veículo: ");
decimal valorVeiculo = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Tipo de combustivel do veículo (1) - Alcool / (2) - Gasolina / (3) - Diesel: ");
int combustivel = Convert.ToInt32(Console.ReadLine());


switch (combustivel)
{
    case 1:
        porcentagem = 0.25M;
        break;
    case 2:
        porcentagem = 0.21M;
        break;
    case 3:
        porcentagem = 0.14M;
        break; 
    default:
        Console.WriteLine("Entrada inválida.");
        break;           
}

decimal porcentagemDesconto = valorVeiculo * porcentagem;
decimal valorFinal = valorVeiculo - porcentagemDesconto;

Console.WriteLine($"Total do Desconto: {porcentagemDesconto}");
Console.WriteLine($"Total a ser pago pelo cliente: {valorFinal}");