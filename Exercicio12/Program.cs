using System;

decimal custoDeFabrica, somaCustosdeFabrica, percentualImposto, percentualDistribuidor;

Console.WriteLine("Informe os custos de fabrica do veículo: ");
custoDeFabrica = Convert.ToDecimal(Console.ReadLine());

//Primeiro os impostos são aplicados sobre o custo de fábrica, e depois o percentual do distribuidor sobre o resultado
percentualImposto = custoDeFabrica * 0.45M;
percentualDistribuidor = (custoDeFabrica + percentualImposto) * 0.28M;
somaCustosdeFabrica = custoDeFabrica + percentualImposto + percentualDistribuidor;


Console.WriteLine($"Custo ao consumidor: {somaCustosdeFabrica.ToString("C2")}");