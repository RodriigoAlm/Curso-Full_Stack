
Console.Write("Digite letras (separados por espaço): ");
string? input = (Console.ReadLine()).ToUpper();

string[] letra = input.Split(" ");
string[] consoante = new string[letra.Length];

int quantidadeConsoantes = 0;
for (int i = 0; i < letra.Length; i++) {
    if (letra[i] != "A" && letra[i] != "E" && letra[i] != "I" && letra[i] != "O" && letra[i] != "U" && letra[i] != " ") {
        quantidadeConsoantes ++;
        Console.Write($"{letra[i]} ");
    }
}
Console.Write($"\nVocê digitou {quantidadeConsoantes} consoantes.");
