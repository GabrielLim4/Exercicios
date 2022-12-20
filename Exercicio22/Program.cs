using System;

decimal precoDeCusto, precoDeVenda, totalCusto = 0, totalVenda = 0;

int i = 0;
for (;i < 4; i++)
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("Digite o preço de Custo: ");
    precoDeCusto = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o preço de Venda: ");
    precoDeVenda = Convert.ToDecimal(Console.ReadLine());

    totalCusto += precoDeCusto;
    totalVenda += precoDeVenda;

    if (precoDeVenda > precoDeCusto)
    {
        Console.WriteLine(" ");
        Console.WriteLine("LUCRO.");
    }
    else if (precoDeVenda == precoDeCusto)
    {
        Console.WriteLine(" ");
        Console.WriteLine("EMPATE.");
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("PREJUIZO.");
    }

    Console.WriteLine(" ");
    Console.WriteLine($"Valor de Custo: {precoDeCusto.ToString("C2")}");
    Console.WriteLine($"Valor de Venda: {precoDeVenda.ToString("C2")}");
}


    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Média do Preço de Custo: {totalCusto / i}");
    Console.WriteLine($"Média do Preço de Venda: {totalVenda / i}");