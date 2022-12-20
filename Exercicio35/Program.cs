using System;

Console.WriteLine("Digite tipo do cliente ((1) - Residência / (2) - Comércio / (3) - Indústria)");
int tipoDoCliente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de energia consumida (em kW/h)");
double energiaConsumida = Convert.ToDouble(Console.ReadLine());

double valorDaConta;

switch (tipoDoCliente)
{
    case 1:
        valorDaConta = energiaConsumida * 0.60;
        Console.WriteLine($"Valor da Conta do Cliente: {valorDaConta.ToString("C2")}");
        break;
    case 2:
        valorDaConta = energiaConsumida * 0.48;
        Console.WriteLine($"Valor da Conta do Cliente: {valorDaConta.ToString("C2")}");
        break;
    case 3:
        valorDaConta = energiaConsumida * 1.29;
        Console.WriteLine($"Valor da Conta do Cliente: {valorDaConta.ToString("C2")}");
        break;
    default:
        Console.WriteLine("Tipo inválido");
        break;
}