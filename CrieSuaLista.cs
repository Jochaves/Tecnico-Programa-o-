System.Console.WriteLine("Faça a sua lista");

List<string> lista = new List<string>();
string opcao = "S";

while (opcao == "S")
{

System.Console.WriteLine("digite um nome para inserir na lista: ");
lista.Add(Console.ReadLine());

// 2º Opção
// string nome = Console.ReadLine();
// lista.add(nome);

System.Console.WriteLine("deseja inserir outro nome? \n(S)sim \n(N)não");
opcao = Console.ReadLine().ToUpper();
}

//organizando a lista em ordem aleatoria
lista.Sort();
System.Console.WriteLine($"A lista tem {lista.Count()} items: ");

//imprimindo lista
foreach (var item in lista)
{
    System.Console.WriteLine(item);
}

Console.ReadKey();