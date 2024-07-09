Console.Write("Digite 2 números (Separados por espaço): ");
string? input = Console.ReadLine();

Console.Write("Digite a conta que deseja fazer. (*, /, +, -): ");
string conta = Console.ReadLine();

if (input is not null) {
    string[] numeros = input.Split(' ');
    double num1 = double.Parse(numeros[0]);
    double num2 = double.Parse(numeros[1]);
    double res;

    if (conta == "+") {
        res = num1 + num2;
            if (res >= 0){
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Positivo");
            } else {
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Negativo");
            }
    }
    if (conta == "-") {
        res = num1 - num2;
            if (res >= 0){
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Positivo");
            } else {
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Negativo");
            }
    }
    if (conta == "*") {
        res = num1 * num2;
            if (res >= 0){
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Positivo");
            } else {
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Negativo");
            }
    }
    if (conta == "/") {
        res = num1 / num2;
            if (res >= 0){
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Positivo");
            } else {
                Console.WriteLine($"O resultado da adição é {res}, esse valor é Negativo");
            }
    }
};
