using System;

decimal valorCompra, valorPrestacoes;

Console.WriteLine(" ");
Console.WriteLine("----------------Loja Mamão Com Açucar----------------");
Console.WriteLine(" ");

Console.WriteLine("Digite o valor total da compra: ");
valorCompra = Convert.ToDecimal(Console.ReadLine());

valorPrestacoes = valorCompra / 5;

Console.WriteLine($"Valor da Prestação: {valorPrestacoes.ToString("C2")} em 5x sem juros.");