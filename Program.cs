// See https://aka.ms/new-console-template for more information
Console.Write("Digite seu nome: ");
    string nome =  Console.ReadLine()!;
    Console.WriteLine("");
Console.Write("Digite seu sobrenome:");
    string sobrenome = Console.ReadLine()!;
      Console.WriteLine("");


Console.Write("Nome completo: ");
Console.WriteLine(nome + " " + sobrenome);
  Console.WriteLine("");
 Console.Write("Nome completo em catálogo: ");
 Console.WriteLine($"{sobrenome.ToUpper()},{nome}{"."}");