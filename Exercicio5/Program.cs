int notaProva1, notaProva2, notaProva3, media;
string nomeAluno;

Console.WriteLine("Digite o nome do Aluno: ");
nomeAluno = Console.ReadLine();

Console.WriteLine("Digite a nota da primeira prova: ");
notaProva1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a nota da segunda prova: ");
notaProva2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a nota da terceira prova: ");
notaProva3 = Convert.ToInt32(Console.ReadLine());

media = (notaProva1 + notaProva2 + notaProva3) / 3;

Console.WriteLine($"Aluno(a): {nomeAluno} \n" +
                  $"Media: {media}");