int[,] matriz = new int[4,4];

for (int linha = 0; linha < matriz.GetLength(0); linha++) {
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++) {
        Console.Write("Digite um número: ");
        matriz[linha,coluna] = int.Parse(Console.ReadLine());
    }
}
int contagem = 0;

foreach (int numeros in matriz) {
    if (numeros > 10) {
        contagem++;
    }
}
Console.WriteLine("\n--------------\n");

for (int linha = 0; linha < matriz.GetLength(0); linha++) {
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++) {
        Console.Write($"{matriz[linha, coluna]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine($"Essa matriz possui {contagem} valores maior que 10");
Console.WriteLine("\n--------------\n");
