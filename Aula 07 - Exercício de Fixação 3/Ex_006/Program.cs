Console.WriteLine("Digite 3 valores diferentes: (Separados por espaço)");
string? input = Console.ReadLine();

if (input is not null) {
    string[] valores = input.Split (' ');
    int num1, num2, num3;

    num1 = int.Parse(valores[0]);
    num2 = int.Parse(valores[1]);
    num3 = int.Parse(valores[2]);

    int maior = Math.Max(Math.Max(num1, num2), num3);
    int menor = Math.Min(Math.Min(num1, num2), num3);

    Console.WriteLine($"O maior valor digitado é {maior} e o menor é {menor}.");
}
