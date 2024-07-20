//Faça um Programa que leia três números e mostre-os em ordem decrescente.
Console.Write("Digite 3 números (Separado por espaço); ");
string? input = Console.ReadLine();

if (input is not null) {
    string[] valores = input.Split();
    int num1 = int.Parse(valores[0]);
    int num2 = int.Parse(valores[1]);
    int num3 = int.Parse(valores[2]);

    int maior = Math.Max(Math.Max (num1, num2), num3);
    int menor = Math.Min(Math.Min (num1, num2), num3);
    int medio = ((num1 + num2 + num3) - (maior + menor));
    Console.WriteLine($"A sequência dos números é {maior}, {medio}, {menor}.");
};
