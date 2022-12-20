int tempCelcius, tempFahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius: ");
tempCelcius = Convert.ToInt32 (Console.ReadLine());

tempFahrenheit = (9*tempCelcius+160) / 5;

Console.WriteLine($"Temperatura em Fahrenheit: {tempFahrenheit}");