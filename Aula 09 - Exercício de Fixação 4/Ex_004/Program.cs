double populacaoA = 80000;
double populacaoB = 200000;

double taxaA = 0.03;
double taxaB = 0.015;
int anos = 0;

do {
    populacaoA += populacaoA * taxaA;
    populacaoB += populacaoB * taxaB;
    anos++;
} while (populacaoA < populacaoB);

Console.WriteLine($"A quantidade de anos necessária para igualar a populacão seria de {anos} anos.");
