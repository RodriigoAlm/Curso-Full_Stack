int[] pares = new int[20];
int[] impares = new int[20];
int[] numeros = new int[20];
int contadorPares = 0;
int contadorImpares = 0;

for (int i = 0; i < 20; i++) {
    Console.Write("Digite 20 numeros: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 20; i++) {
    if (numeros[i] % 2 == 0) {
        pares[contadorPares] = numeros[i];
        contadorPares++;
    } else {
        impares[contadorImpares] = numeros[i];
        contadorImpares++;
    }
}

Console.WriteLine("\nPares:")
foreach (int par in pares) {
    Console.Write($"{pares}");
}

Console.WriteLine("\nImpares:")
foreach (int impar in impares) {
    Console.Write($"{impares}");
}
