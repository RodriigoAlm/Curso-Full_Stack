
Console.Write("Digite seu salário: ");
double salario = double.Parse(Console.ReadLine());
double porcentagem, reajuste, novoSalario;
string? percentual;

if (salario <= 280) {
    porcentagem = 0.2;
    reajuste = salario * porcentagem;
    novoSalario = salario + reajuste;
    percentual = "20%";
} else if (salario <= 700) {
    porcentagem = 0.15;
    reajuste = salario * porcentagem;
    novoSalario = salario + reajuste;
    percentual = "15%";
} else if (salario <= 1500) {
    porcentagem = 0.10;
    reajuste = salario * porcentagem;
    novoSalario = salario + reajuste;
    percentual = "10%";
} else {
    porcentagem = 0.05;
    reajuste = salario * porcentagem;
    novoSalario = salario + reajuste;
    percentual = "5%";
};
Console.WriteLine($"Salário antes do reajuste: R${salario:F2}\nPercentual de aumento aplicado: {percentual}\nO valor de aumento foi R${reajuste:F2}\nNovo salário: R${novoSalario:F2}");
