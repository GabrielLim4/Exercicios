using System.Dynamic;
using System;

int idade, saude, sexo, desejaContinuar = 1, totalApto = 0, totalNaoApto = 0;
string nome;


while (desejaContinuar == 1)
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("Digite o nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine("Digite o Sexo ( (1) - Masculino (2) - Feminino ) ");
    sexo = Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine("Digite o estado de Saúde ( (1) - Apto / (2) - Não Apto) ");
    saude = Convert.ToInt32 (Console.ReadLine());

    if (idade >= 18  && saude == 1 && sexo == 1)
    {
        Console.WriteLine("Apto a cumprir o serviço militar.");
        totalApto++;
    }
    else
    {
        Console.WriteLine("Não está apto a cumprir o serviço militar.");
        totalNaoApto++;
    }
    

    Console.WriteLine("Deseja Continuar? ( (1) - Sim, (2) - Não )");
    desejaContinuar = Convert.ToInt32 (Console.ReadLine());
}

Console.WriteLine($"Total de pessoas aptas a cumprir o serviço militar: {totalApto}");
Console.WriteLine($"Total de pessoas que não está aptas a cumprir o serviço militar: {totalNaoApto}");