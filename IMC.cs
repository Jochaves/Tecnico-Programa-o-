Console.WriteLine("IMC");

Console.Write("Informe sua altura: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Informe seu peso em KG: ");
double p = double.Parse(Console.ReadLine());

double cimc = (p*p)/a;

if (cimc < 18.5)
{
    Console.WriteLine($"abaixo do peso {cimc.ToString("0.0")}"); // .ToString("0.00") controla a quantidade de casa que vão ser mostradas 
}
else if (cimc >= 18.6 && cimc <= 24.9 )
{
    Console.WriteLine($"Peso ideal {cimc.ToString("0.0")}(parabéns) ");
}
else if (cimc >= 25.0 && cimc <= 29.9 )
{
    Console.WriteLine($"Levante acima do peso {cimc.ToString("0.0")} ");
}
else if (cimc > 30.0 && cimc <= 34.9 )
{
    Console.WriteLine($"Obesidade grau | {cimc.ToString("0.0")}");
}
else if (cimc > 35.0 && cimc <= 39.9)
{
    Console.WriteLine($"Obesidade grau || {cimc.ToString("0.0")} (severa) ");
}
else if (cimc >= 40)
{
    Console.WriteLine($"Obesidade grau ||| {cimc.ToString("0.0")} (mórbida) ");
}

Console.ReadKey();













