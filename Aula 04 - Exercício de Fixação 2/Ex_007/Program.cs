Console.Write("Digite seu salário: ");
double salario = double.Parse (Console.ReadLine());

//Conta Reajuste
double reajuste = 0.12;
double conta = salario * reajuste;
double novo_salario = salario + conta;

Console.WriteLine($"Seu novo salário é no valor de R${novo_salario}.");
