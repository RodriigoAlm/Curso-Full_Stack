Console.WriteLine("Limite de Saque: De R$10,00 a R$600,00");
Console.Write("\nValor do saque: ");
int valorSaque = int.Parse(Console.ReadLine());

while (valorSaque < 10 || valorSaque > 600) {
    Console.WriteLine("Valor Inválido.");
    Console.Write("\nValor do saque: ");
    valorSaque = int.Parse(Console.ReadLine());
}

int[] notas = { 100, 50, 10, 5, 1 };
int[] quantidadeNotas = new int[notas.Length];

int valorRestante = valorSaque;

for (int i = 0; i < notas.Length; i++) {
    if (valorRestante >= notas[i]) {
        quantidadeNotas[i] = valorRestante / notas[i];
        valorRestante %= notas[i];
    }
}

Console.WriteLine($"Para sacar a quantia de {valorSaque} reais, você receberá:");

for (int i = 0; i < notas.Length; i++) {
    if (quantidadeNotas[i] > 0) {
        Console.WriteLine($"{quantidadeNotas[i]} nota(s) de {notas[i]} reais");
    }
}
