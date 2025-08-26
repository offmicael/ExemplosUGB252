/*
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());

    Console.WriteLine($"Seu nome é {nome} e seu salário é {salario}");

    //informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto IRPF

    decimal irpfDevido;
    if (salario <= 2259.20m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 169.21m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.015m - 381.44m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.0225m - 662.77m;
    else
        irpfDevido = salario * 0.0275m - 896m;

    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é {irpfDevido}, então o salário com desconto de IRPF será {salario - irpfDevido}");
}
catch (FormatException)
{
    Console.WriteLine("Osalario de ser informado em formato númerico.");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. informe ao suporte técnico");

    Console.WriteLine(e.StackTrace);
}
*/

using ConceitosBasicos.Uteis;
int opcao;

do
{

    Console.WriteLine("[0] - sair");
    Console.WriteLine("[1] - Somar dois números");
    Console.WriteLine("[2] - Converter metros em milímetros");
    Console.WriteLine("[3] - Calcular aumento de salário");
    Console.WriteLine("Escolha a opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {

        case 1:

            SomaDoisNumeros somaDoisNumeros = new
                SomaDoisNumeros();
            int resultado = somaDoisNumeros.Somar(20, 22);
            Console.WriteLine(resultado);
            break;

        case 2:

            int milimetros = MetrosMilimetros.Converter(2);
            break;

        case 3:
            CalculoAumento calculaAumento = new CalculoAumento();
            Console.Write("Informe o salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o novo percentual so aumento: ");
            float percentual = float.Parse(Console.ReadLine());
            decimal percentualAumento = calculaAumento.Calcular(salario, percentual);
            Console.WriteLine($"Para o salário {salario:c2}, o aumento de {percentual:f2} correspondea {percentualAumento}");
            Console.WriteLine($"O novo salário é {salario + percentualAumento}");
            break;

        default:

            Console.WriteLine("Opção invalida");
            break;
    }

} while (opcao != 0);
