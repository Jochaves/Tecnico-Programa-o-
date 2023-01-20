// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Aluno!");

// --- Nome e idade ---

string nome, sobrenome; //declaração de variáveis 
int idade;

Console.Write("Digite seu nome: "); // Saída
nome = Console.ReadLine(); // entrada 

Console.Write("Digite seu sobrenome: "); // Saída
sobrenome = Console.ReadLine(); // entrada

Console.WriteLine("Digite sua idade: "); // Saída
idade = int.Parse(Console.ReadLine()); // entrada  // int.Perse converte em um valor inteiro 

Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine();

// concatenando saída
Console.Write(nome + " " + sobrenome + " tem " + idade + " anos de idade. ");
Console.ReadKey(); //interrompe execução