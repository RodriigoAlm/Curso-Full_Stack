double peso, excesso, multa;

Console.Write("Digite o peso dos peixes: ");
peso = double.Parse(Console.ReadLine());

excesso = peso - 50;
multa = excesso * 4;

if (excesso > 0) {
    Console.WriteLine($"\nMULTADO\nVocê excedeu {excesso:F2} kg do peso\nA multa é no valor de R${multa}");
} else {
    Console.WriteLine("\nSem multa\nVocê excedeu ZERO kg do peso\nA multa é no valor de ZERO");
};
