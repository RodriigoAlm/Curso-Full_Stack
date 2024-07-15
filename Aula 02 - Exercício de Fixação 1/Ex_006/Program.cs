/* Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o valor, 
seu antecessor e seu sucessor (cada um em uma linha). */

Console.Write("Digite um valor: ");
int valor = int.Parse (Console.ReadLine());

Console.Write($"{valor - 1} \n{valor} \n{valor + 1}");
