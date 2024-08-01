int coluna = 0;
int linha = 0;
int maior = 0;

int[,] numeros = new int[4,4] {
    {1,56,12,45},
    {10,11,9,25},
    {120,22,89,5},
    {57,3,67,43}
};

for (int i = 0; i < numeros.GetLength(0); i++) {
    for (int c = 0; c < numeros.GetLength(1); c++) {
        if (numeros[i,c] > maior) {
            maior = numeros[i,c];
            linha = i;
            coluna = c;
        }
    }
}

Console.WriteLine($"O maior número da matriz é: {maior}. Está na posição [{linha},{coluna}]");
