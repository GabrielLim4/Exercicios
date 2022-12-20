using System;




decimal cotacaoDolar, dolar, real;

Console.WriteLine("Digite o valor de dólares dísponível na sua conta: ");
dolar = Convert.ToDecimal (Console.ReadLine());

Console.WriteLine("Digite o valor da cotação do Dólar: ");
cotacaoDolar = Convert.ToDecimal (Console.ReadLine());


real = dolar * cotacaoDolar;

Console.WriteLine($"Você tem {dolar} dólares em sua conta.");
Console.WriteLine($"Valor convertido em Real: {real:C}");