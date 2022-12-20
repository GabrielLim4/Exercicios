using System;

int numeroDoMes;

Console.WriteLine("Digite o número do Mês: ");
numeroDoMes = Convert.ToInt32(Console.ReadLine());

switch (numeroDoMes)
{
    case 1:
        Console.WriteLine("JANEIRO");
        break;
    case 2:
        Console.WriteLine("FEVEREIRO");
        break;
    case 3:
        Console.WriteLine("MARÇO");
        break;
    case 4:
        Console.WriteLine("ABRIL");
        break;
    case 5:
        Console.WriteLine("MAIO");
        break;
    case 6:
        Console.WriteLine("JUNHO");
        break;    
    case 7:
        Console.WriteLine("JULHO");
        break;
    case 8:
        Console.WriteLine("AGOSTO");
        break;
    case 9:
        Console.WriteLine("SETEMBRO");
        break;
    case 10:
        Console.WriteLine("OUTUBRO");
        break;
    case 11:
        Console.WriteLine("NOVEMBRO");
        break;
    case 12:
        Console.WriteLine("DEZEMBRO");
        break;   
    default:
        Console.WriteLine("Número Inválido.");
        break;
}