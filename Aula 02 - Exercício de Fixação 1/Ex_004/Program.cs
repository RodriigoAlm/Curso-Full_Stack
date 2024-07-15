// Escreva um algoritmo para ler as dimensões de um quadrado e mostre sua área (base * altura ou base ).

Console.Write("Digite a base: ");
double lado = double.Parse (Console.ReadLine());
Console.Write("Digite a altura: ");
double altura = double.Parse (Console.ReadLine());

Console.WriteLine($"A área é igual a {lado * altura}m²");
