string sexo;
Console.WriteLine ("Digite 'h' para homem, 'm' para mulher ou qualquer tecla para sair: ");

sexo = Console.ReadLine();
if (sexo == "h" || sexo == "H")
{
    Console.WriteLine("sexo masculino");

}
else if ((sexo == "m" || sexo == "M"))
{
    Console.WriteLine("sexo feminino");
}
else
{
    Environment.Exit(0);
}
Console.ReadKey(); 





