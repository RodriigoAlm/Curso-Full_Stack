Console.Write("Digite uma nota de 0 a 10: ");
byte nota = byte.Parse(Console.ReadLine());

while (nota > 10) {
    Console.WriteLine("A nota digitada é maior que 10, digite novamente: (0 a 10).");
    nota = byte.Parse(Console.ReadLine());
};
Console.WriteLine($"\nA nota digitada foi: {nota}");
