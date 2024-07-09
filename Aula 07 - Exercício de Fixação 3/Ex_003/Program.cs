Console.Write("Digite o sexo (F ou M): ");
string? sexo = Console.ReadLine();

if (sexo == "F" || sexo == "f") {
    Console.WriteLine("Sexo Feminino.");
} else if (sexo == "M" || sexo == "m") {
    Console.WriteLine("Sexo Masculino.");
} else {
    Console.WriteLine("Valor inválido.");
}
