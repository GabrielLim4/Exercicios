int variavelA, variavelB, variavelC;

Console.WriteLine("Digite o valor da variável A: ");
variavelA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Digite o valor da variável B: ");
variavelB = Convert.ToInt32 (Console.ReadLine());

variavelC = variavelA;
variavelA = variavelB;
variavelB = variavelC;

Console.WriteLine($"Variavel A: {variavelA}");
Console.WriteLine($"Variavel B: {variavelB}");