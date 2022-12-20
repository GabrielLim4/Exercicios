using System;

string nome;
decimal salarioFuncionario, salarioMinimo, reajuste = 0, salarioReajustado = 0, aumentoTotal = 0;
char desejaContinuar = 'S';
int cont = 0;

Console.WriteLine("Digite o salario minimo: ");
    salarioMinimo = Convert.ToDecimal(Console.ReadLine());

while(desejaContinuar == 'S' || desejaContinuar == 's')
{
    Console.WriteLine("Digite o nome do funcionario: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o salario atual do funcionario: ");
    salarioFuncionario = Convert.ToDecimal(Console.ReadLine());


    if (salarioFuncionario <= 3 * salarioMinimo)
    {
        reajuste = salarioFuncionario * 0.50M;
    }
    else if (salarioFuncionario > 3 * salarioMinimo && 
            salarioFuncionario <= 10 * salarioMinimo)
    {
        reajuste = salarioFuncionario * 0.20M;
    }
    else if (salarioFuncionario > 10 * salarioMinimo && 
            salarioFuncionario <= 20 * salarioMinimo)
    {
        reajuste = salarioFuncionario * 0.15M;
    }
    else
    {
        reajuste = salarioFuncionario * 0.10M;
    }


    salarioReajustado = salarioFuncionario + reajuste;

    Console.WriteLine($"Nome do Funcionário: {nome}");
    Console.WriteLine($"Reajuste: {reajuste.ToString("C2")}");
    Console.WriteLine($"Novo Salário: {salarioReajustado.ToString("C2")}");

    aumentoTotal += reajuste;
    cont++;

    Console.WriteLine("Deseja continuar? (S) - Sim / (N) - Não");
    desejaContinuar = Convert.ToChar(Console.ReadLine());
}

Console.WriteLine($"Aumento total da folha de pagamento: {aumentoTotal.ToString("C2")}.");
Console.WriteLine($"Funcionários calculados: {cont}");