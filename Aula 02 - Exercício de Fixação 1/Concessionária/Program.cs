/* O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor 
e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do distribuidor seja de 28% 
e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro, calcular e escrever 
o custo final ao consumidor.  */

Console.Write("Digite o valor de fábrica do carro: ");
double valor_carro = double.Parse (Console.ReadLine());

double percentual_distribuidor = valor_carro * 0.28;
double impostos = valor_carro * 0.45;

double total_carro = (valor_carro + impostos + percentual_distribuidor);
Console.WriteLine($"\nO valor total do carro é R${total_carro}\n");
