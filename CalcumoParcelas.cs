Console.WriteLine("Parcelas");
repeat:
Console.WriteLine("Digite o valor á ser solicitado a partir de R$1.000,00");
double valor = double.Parse(Console.ReadLine());

const double parametro = 1000;
if(valor < parametro)
{

    goto repeat;
}

double result;
Console.WriteLine("(1) para pagamentos á vista com 5% de desconto \n (2) para pagamntos parcelados em 4x com 18% de juros \n (3) para pagamento parcelado em 12x com 62% de juros");
string opcao = Console.ReadLine();

// refatorando para switch case
// Alt + Shift + f = organizar código
// seleciona Ctrl + ; = comenta o código de uma vez 

switch (opcao)
{
    case "1":
       result = valor * 0.95;
       Console.WriteLine($"pagamento á vista com 5% de desconto - parcela única de {result.ToString("c")}");
       break;
    case "2":
       result = (valor * 1.18) / 4;
       Console.WriteLine($"pagamento parcelado em 4x com 18% de juros - 4 parcelas de {result.ToString("c")}");
       break;
    case "3":
       result = (valor * 1.62) / 12;
       Console.WriteLine($"pagamento parcelado em 12x com 62% de juros - 12 parcelas de {result.ToString("c")}");
       break;
    default:
    Console.WriteLine("Opção Inválida !!");
    goto repeat;
    //break;

}













