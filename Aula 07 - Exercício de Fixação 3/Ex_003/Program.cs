Console.Write("Digite o sexo (F ou M): ");
string? sexo = Console.ReadLine();
string? sexoM = sexo.ToUpper();

if (sexoM == "F") {
    Console.WriteLine("Sexo Feminino.");
} else if (sexoM == "M") {
    Console.WriteLine("Sexo Masculino.");
} else {
    Console.WriteLine("Valor inválido.");
}
