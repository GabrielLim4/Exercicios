// Escreva um algoritmo para determinar o consumo médio de um automóvel sendo fornecida a distância total 
// percorrida pelo automóvel e o total de combustível gasto

double consumoMedioAutomovel, distanciaTotalPercorrida, totalCombustivelGasto;

Console.WriteLine("Digite a distancia total percorrida pelo automovel: ");
distanciaTotalPercorrida = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o total de combustível gasto: ");
totalCombustivelGasto = Convert.ToDouble(Console.ReadLine());


consumoMedioAutomovel = distanciaTotalPercorrida / totalCombustivelGasto;


Console.WriteLine($"Esse automóvel consome 1 litro a cada {consumoMedioAutomovel} quilometros");