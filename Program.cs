string nome, sobrenome;
Console.Write("Fernanda.......: ");
nome = Console.ReadLine()!;

Console.Write("Oliveira.: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Fernanda Oliveira: {nome} {sobrenome}");
Console.WriteLine($"Oliveira Fernanda: {sobrenome.ToUpper()}, {nome}");