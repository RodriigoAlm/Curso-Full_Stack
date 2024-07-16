/* Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo. */

Console.Write("Digite um valor: ");
int valor = int.Parse(Console.ReadLine());

if (valor < 0) {
    Console.WriteLine("Esse valor é negativo.");
} else if (valor > 0) {
    Console.WriteLine("Esse valor é positivo.");
} else if (valor == 0) {
    Console.WriteLine($"O valor {valor} é neutro");
};
