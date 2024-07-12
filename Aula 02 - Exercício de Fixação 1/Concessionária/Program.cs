Console.Write("Digite o valor de fábrica do carro: ");
double valor_carro = double.Parse (Console.ReadLine());

double percentual_distribuidor = valor_carro * 0.28;
double impostos = valor_carro * 0.45;

double total_carro = (valor_carro + impostos + percentual_distribuidor);
Console.WriteLine($"\nO valor total do carro é R${total_carro}\n");
