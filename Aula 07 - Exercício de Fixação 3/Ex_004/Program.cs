Console.Write("Digite uma letra: ");
string? input = Console.ReadLine();
string? letra = input.ToUpper();

if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U") {
    Console.WriteLine($"Essa letra {letra}, é uma vogal");
} else {
    Console.WriteLine($"Essa letra {letra}, é uma consoante");
};
