using System;


decimal valorDepositado, rendimento, rendimentoAno;

Console.WriteLine("Digite o valor depositado: ");
valorDepositado = Convert.ToDecimal(Console.ReadLine());

rendimento = valorDepositado *= 0.0007M;
rendimentoAno = rendimento * 12;

Console.WriteLine($"Rendimento: {rendimento.ToString("C2")} ao mês. Ao ano: {rendimentoAno.ToString("C2")}");