Console.Write("Digite a população A: ");
double populacaoA = double.Parse(Console.ReadLine());
Console.Write("Digite a população B: ");
double populacaoB = double.Parse(Console.ReadLine());

Console.Write("Digite a taxa A: ");
double inputTaxaA = double.Parse(Console.ReadLine());
Console.Write("Digite a taxa B: ");
double inputTaxaB = double.Parse(Console.ReadLine());

double taxaA = inputTaxaA / 100;
double taxaB = inputTaxaB / 100;
int anos = 0;

do {
    populacaoA += populacaoA * taxaA;
    populacaoB += populacaoB * taxaB;
    anos++;
} while (populacaoA <= populacaoB);

Console.WriteLine($"A quantidade de anos necessária para igualar a populacão seria de {anos} anos.");
