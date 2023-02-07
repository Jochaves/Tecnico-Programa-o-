Console.WriteLine("Array - Vetor");
System.Console.WriteLine("Lanches");
string[] l = { "Xsalada", "Xovo", "Xbanana", "Xtudo", "Xnada" };
double[] p = { 20.0, 15.0, 12.5, 8.5, 15.9 };
string[] s = { "Laranja", "Limão", "Banana" };
double[] ps = { 10.0, 8.0, 10.5 };


etiqueta:
System.Console.WriteLine("Escolha um lanche:\n(1)Xsalada\n(2)Xovo\n(3)Xbanana\n(4)Xtudo\n(5)Xnada");
string op = Console.ReadLine();
switch (op)
{
    case "1":
        Console.WriteLine($"O lanche escolhido foi: {l[0]}\nSeu preço é: {p[0].ToString("c")}\nDeseja acrescentar um suco?\n(1)Sim\n(2)Não");
        string opcao1 = Console.ReadLine();

        if (opcao1 == "1")
        {
            etiqueta1:
            System.Console.WriteLine("Escolha o suco:\n(1)Laranja\n(2)Limão\n(3)Banana");
            string opcSuco = Console.ReadLine();
            switch (opcSuco)
            {
                case "1":
                    double tt1 = p[0] + ps[0];
                    Console.WriteLine($"O lanche escolhido foi: {l[0]}\nSeu preço é: {p[0].ToString("c")}\nO suco escolhido foi {s[0]}\nSeu preço é : {ps[0].ToString("c")}\nO total da compra é: {tt1.ToString("c")}");
                    break;
                case "2":
                    double tt2 = p[0] + ps[1];
                    Console.WriteLine($"O lanche escolhido foi: {l[0]}\nSeu preço é: {p[0].ToString("c")}\nO suco escolhido foi {s[1]}\nSeu preço é : {ps[1].ToString("c")}\nO total da compra é: {tt2.ToString("c")}");
                    break;
                case "3":
                    double tt3 = p[0] + ps[2];
                    Console.WriteLine($"O lanche escolhido foi: {l[0]}\nSeu preço é: {p[0].ToString("c")}\nO suco escolhido foi {s[2]}\nSeu preço é : {ps[2].ToString("c")}\nO total da compra é: {tt3.ToString("c")}");
                    break;
                default:
                Console.WriteLine("Opção Inválida !!");
                goto etiqueta1;
            }
        }
        else 
        {
            return;
        }
        break;
     case "2":
        Console.WriteLine($"O lanche escolhido foi: {l[1]}\nSeu preço é: {p[1].ToString("c")}\nDeseja acrescentar um suco?\n(1)Sim\n(2)Não");
        string opcao2 = Console.ReadLine();
        if (opcao2 == "1")
        {
            etiqueta2:
            System.Console.WriteLine("Escolha o suco:\n(1)Laranja\n(2)Limão\n(3)Banana");
            string opcSuco = Console.ReadLine();
            switch (opcSuco)
            {
                case "1":
                    double tt1 = p[1] + ps[0];
                    Console.WriteLine($"O lanche escolhido foi: {l[1]}\nSeu preço é: {p[1].ToString("c")}\nO suco escolhido foi {s[0]}\nSeu preço é : {ps[0].ToString("c")}\nO total da compra é: {tt1.ToString("c")}");
                    break;
                case "2":
                    double tt2 = p[1] + ps[1];
                    Console.WriteLine($"O lanche escolhido foi: {l[1]}\nSeu preço é: {p[1].ToString("c")}\nO suco escolhido foi {s[1]}\nSeu preço é : {ps[1].ToString("c")}\nO total da compra é: {tt2.ToString("c")}");
                    break;
                case "3":
                    double tt3 = p[1] + ps[2];
                    Console.WriteLine($"O lanche escolhido foi: {l[1]}\nSeu preço é: {p[1].ToString("c")}\nO suco escolhido foi {s[2]}\nSeu preço é : {ps[2].ToString("c")}\nO total da compra é: {tt3.ToString("c")}");
                    break;
                default:
                Console.WriteLine("Opção Inválida !!");
                goto etiqueta2;
            }
        }
        else 
        {
            return;
        }
        break;
    case "3":
        Console.WriteLine($"O lanche escolhido foi: {l[2]}\nSeu preço é: {p[2].ToString("c")}\nDeseja acrescentar um suco?\n(1)Sim\n(2)Não");
        string opcao3 = Console.ReadLine();
        if (opcao3 == "1")
        {
            etiqueta3:
            System.Console.WriteLine("Escolha o suco:\n(1)Laranja\n(2)Limão\n(3)Banana");
            string opcSuco = Console.ReadLine();
            switch (opcSuco)
            {
                case "1":
                    double tt1 = p[2] + ps[0];
                    Console.WriteLine($"O lanche escolhido foi: {l[2]}\nSeu preço é: {p[2].ToString("c")}\nO suco escolhido foi {s[0]}\nSeu preço é : {ps[0].ToString("c")}\nO total da compra é: {tt1.ToString("c")}");
                    break;
                case "2":
                    double tt2 = p[2] + ps[1];
                    Console.WriteLine($"O lanche escolhido foi: {l[2]}\nSeu preço é: {p[2].ToString("c")}\nO suco escolhido foi {s[1]}\nSeu preço é : {ps[1].ToString("c")}\nO total da compra é: {tt2.ToString("c")}");
                    break;
                case "3":
                    double tt3 = p[2] + ps[2];
                    Console.WriteLine($"O lanche escolhido foi: {l[3]}\nSeu preço é: {p[2].ToString("c")}\nO suco escolhido foi {s[2]}\nSeu preço é : {ps[2].ToString("c")}\nO total da compra é: {tt3.ToString("c")}");
                    break;
                default:
                Console.WriteLine("Opção Inválida !!");
                goto etiqueta3;
            }
        }
        else 
        {
            return;
        }
        break;
      
    case "4":
        Console.WriteLine($"O lanche escolhido foi: {l[3]}\nSeu preço é: {p[3].ToString("c")}\nDeseja acrescentar um suco?\n(1)Sim\n(2)Não");
        string opcao4 = Console.ReadLine();
        if (opcao4 == "1")
        {
            etiqueta4:
            System.Console.WriteLine("Escolha o suco:\n(1)Laranja\n(2)Limão\n(3)Banana");
            string opcSuco = Console.ReadLine();
            switch (opcSuco)
            {
                case "1":
                    double tt1 = p[3] + ps[0];
                    Console.WriteLine($"O lanche escolhido foi: {l[3]}\nSeu preço é: {p[3].ToString("c")}\nO suco escolhido foi {s[0]}\nSeu preço é : {ps[0].ToString("c")}\nO total da compra é: {tt1.ToString("c")}");
                    break;
                case "2":
                    double tt2 = p[3] + ps[1];
                    Console.WriteLine($"O lanche escolhido foi: {l[3]}\nSeu preço é: {p[3].ToString("c")}\nO suco escolhido foi {s[1]}\nSeu preço é : {ps[1].ToString("c")}\nO total da compra é: {tt2.ToString("c")}");
                    break;
                case "3":
                    double tt3 = p[3] + ps[2];
                    Console.WriteLine($"O lanche escolhido foi: {l[3]}\nSeu preço é: {p[3].ToString("c")}\nO suco escolhido foi {s[2]}\nSeu preço é : {ps[2].ToString("c")}\nO total da compra é: {tt3.ToString("c")}");
                    break;
                default:
                Console.WriteLine("Opção Inválida !!");
                goto etiqueta4;
            }
        }
        else 
        {
            return;
        }
        break;
    case "5":
       Console.WriteLine($"O lanche escolhido foi: {l[4]}\nSeu preço é: {p[4].ToString("c")}\nDeseja acrescentar um suco?\n(1)Sim\n(2)Não");
        string opcao5 = Console.ReadLine();
        if (opcao5 == "1")
        {
            etiqueta5:
            System.Console.WriteLine("Escolha o suco:\n(1)Laranja\n(2)Limão\n(3)Banana");
            string opcSuco = Console.ReadLine();
            switch (opcSuco)
            {
                case "1":
                    double tt1 = p[4] + ps[0];
                    Console.WriteLine($"O lanche escolhido foi: {l[4]}\nSeu preço é: {p[4].ToString("c")}\nO suco escolhido foi {s[0]}\nSeu preço é : {ps[0].ToString("c")}\nO total da compra é: {tt1.ToString("c")}");
                    break;
                case "2":
                    double tt2 = p[4] + ps[1];
                    Console.WriteLine($"O lanche escolhido foi: {l[4]}\nSeu preço é: {p[4].ToString("c")}\nO suco escolhido foi {s[1]}\nSeu preço é : {ps[1].ToString("c")}\nO total da compra é: {tt2.ToString("c")}");
                    break;
                case "3":
                    double tt3 = p[4] + ps[2];
                    Console.WriteLine($"O lanche escolhido foi: {l[4]}\nSeu preço é: {p[4].ToString("c")}\nO suco escolhido foi {s[2]}\nSeu preço é : {ps[2].ToString("c")}\nO total da compra é: {tt3.ToString("c")}");
                    break;
                default:
                Console.WriteLine("Opção Inválida !!");
                goto etiqueta5;
            }
        }
        else 
        {
            return;
        }
        break;
    default:
        Console.WriteLine($"Opção inválida !!");
        goto etiqueta;
}

Console.ReadKey();