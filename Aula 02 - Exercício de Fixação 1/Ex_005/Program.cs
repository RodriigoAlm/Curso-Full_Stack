/* Faça um Programa que peça o raio de um círculo, 
calcule e mostre sua área (area do círculo = 3.14 * raio ao quadrado). */

Console.Write("Digite o raio do círculo: ");
double raio = double.Parse (Console.ReadLine());

Console.WriteLine($"{3.14 * (raio * raio)}m²");
