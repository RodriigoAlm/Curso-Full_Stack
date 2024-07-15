Console.Write("Digite o usuário: ");
string? usuario = Console.ReadLine();

Console.Write("Digite a senha: ");
string? senha = Console.ReadLine();

while (usuario == senha) {

    Console.WriteLine("\nInformações incorretas.");

    Console.Write("Digite o usuário: ");
    usuario = Console.ReadLine();

    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();
};
Console.WriteLine("\nConectado!");
