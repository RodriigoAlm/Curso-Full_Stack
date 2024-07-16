// Faça um Programa que verifique se uma letra digitada é "F" ou "M".
// Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido. 


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
