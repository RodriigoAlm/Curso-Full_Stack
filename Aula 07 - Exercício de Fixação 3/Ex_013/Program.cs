// Pegar os dados (peso e sexo);
double altura, pesoIdeal, pesoAtual, diferenca;
string? input2, sexo, strPeso;
double limite = 5;

Console.Write("Digite sua altura: ");
altura = double.Parse(Console.ReadLine());
Console.Write("Digite su sexo: (F ou M): ");
input2 = Console.ReadLine();
sexo = input2.ToUpper();

if (sexo == "M") {
    pesoIdeal = (72.7 * altura) - 58;
} else {
    pesoIdeal = (62.1 * altura) - 44.7; 
};
Console.Write("Digite seu peso atual: ");
pesoAtual = double.Parse(Console.ReadLine());

if (pesoAtual > pesoIdeal) {
    diferenca = (pesoAtual - pesoIdeal);
    strPeso = "acima do peso";
} else if (pesoIdeal > pesoAtual) {
    diferenca = (pesoIdeal - pesoAtual);
    strPeso = "abaixo do peso";
} else {
    diferenca = 0;
    strPeso = "no peso ideal";
};

if (diferenca <= limite) {
    strPeso = "no peso ideal";
};
Console.WriteLine("\n-------------------");
Console.WriteLine($"\nPeso Atual: {pesoAtual} kg\nPeso Ideal: {pesoIdeal:F2} kg\nDiferença de Peso: {diferenca:F2} kg \nVocê está {strPeso}");
