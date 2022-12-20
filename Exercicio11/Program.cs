using System;

decimal precoDeCusto, percentualCusto, valorDeVenda, acrescimoTotal;

Console.WriteLine("Digite o preço de custo do produto: ");
precoDeCusto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o percentual sobre o custo: ");
percentualCusto = Convert.ToDecimal(Console.ReadLine());

acrescimoTotal = (percentualCusto / 100) * precoDeCusto;
valorDeVenda = acrescimoTotal + precoDeCusto;

Console.WriteLine($"Valor Total: {valorDeVenda.ToString("C2")}");