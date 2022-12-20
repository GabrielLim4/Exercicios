using System;

Console.WriteLine("Nome do Vendedor: ");
string nomeVendedor = Console.ReadLine();

Console.WriteLine("Salario fixo: ");
decimal salarioFixo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Total de Vendas: ");
int totalDeVendas = Convert.ToInt32(Console.ReadLine());

decimal comissaoPorVenda = salarioFixo * 0.15M;
decimal salarioVendedor = salarioFixo + comissaoPorVenda;


Console.WriteLine($"Salario do Vendedor com comissão: {salarioVendedor.ToString("C2")}");