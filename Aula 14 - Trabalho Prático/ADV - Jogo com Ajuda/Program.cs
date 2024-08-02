var numero_aleatorio = new Random();
int valor = 0 ,vidas = 0, chute = 0;

Console.WriteLine("\n----- Adivinhando o Número -----");
    
Console.WriteLine("\n     ---Níveis---\nFácil: De 1-10 (3 vidas)\nMédio: De 1-50 (4 vidas)\nDifícil: De 1-100 (5 vidas)\n");
Console.Write("Digite o nível desejado: ");
string nivel = (Console.ReadLine()).ToUpper();

while (nivel != "FACIL" && nivel != "MEDIO" && nivel != "DIFICIL") {
    Console.WriteLine("\n[ERRO] Nível Inválido!\n");
    Environment.Exit(0);
}

if (nivel == "FACIL") {
    valor = numero_aleatorio.Next(1, 10 + 1);
    vidas = 3;
} else if (nivel == "MEDIO") {
    valor = numero_aleatorio.Next(1, 50 + 1);
    vidas = 4;
} else {
    valor = numero_aleatorio.Next(1, 100 + 1);
    vidas = 5;
}

Console.Write("Chute um número: ");
chute = int.Parse(Console.ReadLine());
vidas--;

if (nivel == "FACIL") {
    while (chute != valor && vidas > 0) {
        if (chute < 1 || chute > 10) {
        Console.WriteLine("\nValor Inválido, apenas chutes entre 1 e 10.");
    } else if (chute < valor) {
        Console.WriteLine("\nSeu chute foi abaixo do valor.");
    } else if (chute > valor) {
        Console.WriteLine("\nSeu chute foi acima do valor.");
    }
        Console.Write("Chute outro número: ");
        chute = int.Parse(Console.ReadLine());
        vidas--;
    } 
    if (chute == valor) {
        Console.WriteLine($"\n   -----Parabéeens, você acertou o número!!!-----\n");
    } else if (chute != valor && vidas == 0) {
        Console.WriteLine($"\n   -----Você perdeu-----\nO valor era {valor}\n");
    }
} else if (nivel == "MEDIO") {
    while (chute != valor && vidas > 0) {
        if (chute < 1 || chute > 50) {
        Console.WriteLine("\nValor Inválido, apenas chutes entre 1 e 50.");
    } else if (chute < valor) {
        Console.WriteLine("\nSeu chute foi abaixo do valor.");
    } else if (chute > valor) {
        Console.WriteLine("\nSeu chute foi acima do valor.");
    }
        Console.Write("Chute outro número: ");
        chute = int.Parse(Console.ReadLine());
        vidas--;
    } 
    if (chute == valor) {
        Console.WriteLine($"\n   -----Parabéeens, você acertou o número!!!-----\n");
    } else if (chute != valor && vidas == 0) {
        Console.WriteLine($"\n   -----Você perdeu-----\nO valor era {valor}\n");
    }
} else {
    while (chute != valor && vidas > 0) {
        if (chute < 1 || chute > 100) {
        Console.WriteLine("\nValor Inválido, apenas chutes entre 1 e 100.");
    } else if (chute < valor) {
        Console.WriteLine("\nSeu chute foi abaixo do valor.");
    } else if (chute > valor) {
        Console.WriteLine("\nSeu chute foi acima do valor.");
    }
        Console.Write("Chute outro número: ");
        chute = int.Parse(Console.ReadLine());
        vidas--;
    } 
    if (chute == valor) {
        Console.WriteLine($"\n   -----Parabéeens, você acertou o número!!!-----\n");
    } else if (chute != valor && vidas == 0) {
        Console.WriteLine($"\n   -----Você perdeu-----\nO valor era {valor}\n");
    }
}
