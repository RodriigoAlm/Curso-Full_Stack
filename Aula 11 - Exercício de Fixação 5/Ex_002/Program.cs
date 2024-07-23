
Console.Write("Digite 10 letras (separados por espaço): ");
string? input = (Console.ReadLine()).ToUpper();

string[] letra = input.Split(" ");
string[] consoantes = new string[10];
int quantidadeConsoantes = 0;

for (int i = 0; i < letra.Length; i++) {
    if (letra[i] != "A" && letra[i] != "E" && letra[i] != "I" && letra[i] != "O" && letra[i] != "U") {
        consoantes[quantidadeConsoantes] = letra[i];
        quantidadeConsoantes++;
    }
}
Console.WriteLine($"\nVocê digitou {quantidadeConsoantes} consoantes.");
Console.WriteLine("\nForam essas:");

for (int i = 0; i <= quantidadeConsoantes; i++) {
    Console.Write($"{consoantes[i]} ");
}
Console.WriteLine("\n-------------");
