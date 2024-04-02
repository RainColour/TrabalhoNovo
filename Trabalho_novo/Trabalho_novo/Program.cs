using AdivinharNumero;
using CalculaAumentoRetorno;
using CalculaAumentoStatic;

int opcao;

do
{
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Calcular Aumento(Static)");
    Console.WriteLine("2) Calcular Aumento");
    Console.WriteLine("3) Adivinhar");

    Console.Write("Escolha uma opção: ");

    try
    {
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("\nDigite o salário: R$ ");
            decimal salarioS = decimal.Parse(Console.ReadLine());
            Console.Write("\nDigite a taxa de aumento (%): ");
            decimal taxaS = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\nO novo salário é: R$ {CalculadoraAumentoS.CalcularAumento(salarioS, taxaS)}\n");
        }
        else if (opcao == 2)
        {
            Console.Write("\nDigite o salário: R$ ");
            decimal salarioR = decimal.Parse(Console.ReadLine());
            Console.Write("\nDigite a taxa de aumento (%): ");
            decimal taxaR = decimal.Parse(Console.ReadLine());

            CalculadoraAumento calculadora = new CalculadoraAumento();
            decimal nSalario = calculadora.CalcularAumento(salarioR, taxaR);
            Console.WriteLine($"\nO novo salário é: R$ {nSalario}\n");
        }
        else if (opcao == 3)
        {
            Ad adivinhar = new Ad();
            adivinhar.Adivinhar();
        }
        else if (opcao == 0)
        {
            Console.WriteLine("Saindo...");
            Console.WriteLine("\r\nVinicius Mota - 2022102148\r\nLuiz Vinicius - 2022102059\r\nPedro Yago - 2022102058");
        }
        else
        {
            Console.WriteLine("\nOpção inválida. Escolha outra opção.\n");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("\nEntrada inválida. Por favor, insira um número inteiro válido.\n");
        opcao = -1;
    }
} while (opcao != 0);




//TODO static + retorno -> trocar double por decimal X
//TODO PROGRAM -> usar try - catch + adicionar outras opções X
//TODO adivinhar -> trocar while true e muda 1,11 por 1,100 X
//TODO Todos -> arrumar nomes X