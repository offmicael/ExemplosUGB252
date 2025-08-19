using System.ComponentModel.Design;

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
