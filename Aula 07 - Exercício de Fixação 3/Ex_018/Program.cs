
string[] perguntas = {
    "Telefonou para a vítima? ",
    "Esteve no local do crime? ",
    "Mora perto da vítima? ",
    "Devia para a vítima? ",
    "Já trabalhou com a vítima? "
};

int contadorSim = 0;

foreach (string pergunta in perguntas) {
    Console.Write(pergunta);
    string resposta = Console.ReadLine();

    if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase) || resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        contadorSim++;
    }
}

string classificacao;

if (contadorSim == 2) {
    classificacao = "Suspeita";
} else if (contadorSim >= 3 && contadorSim <= 4) {
    classificacao = "Cúmplice";
} else if (contadorSim == 5) {
    classificacao = "Assassino";
} else {
    classificacao = "Inocente";
}

Console.WriteLine("Classificação: " + classificacao);
