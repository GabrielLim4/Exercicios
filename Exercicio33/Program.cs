using System;


Console.WriteLine("Digite as horas trabalhadas do professor(a): ");
int horasAula = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o nível do professor(a) (1) (2) (3):");
int nivelProfessor = Convert.ToInt32(Console.ReadLine());

decimal valorHora, salarioProfessor;

switch (nivelProfessor)
{
    case 1:
        valorHora = 12.00M;
        salarioProfessor = (horasAula * valorHora);
        Console.WriteLine($"O(A) professor(a) receberá {salarioProfessor.ToString("C2")} pelo dia trabalhado.");
        break;

    case 2:
        valorHora = 17.00M;
        salarioProfessor = horasAula * valorHora;
        Console.WriteLine($"O(A) professor(a) receberá {salarioProfessor.ToString("C2")} pelo dia trabalhado.");
        break;

    case 3:
        valorHora = 25.00M;
        salarioProfessor = horasAula * valorHora;
        Console.WriteLine($"O(A) professor(a) receberá {salarioProfessor.ToString("C2")} pelo dia trabalhado.");
        break;
    default:
        Console.WriteLine("Número inválido. Digite apenas os níveis 1, 2 ou 3.");
        break;            
}        