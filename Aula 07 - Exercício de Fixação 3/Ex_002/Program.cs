/* Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar
 (Adição, Subtração, Soma ou Divisão). O resultado da operação deve ser acompanhado de uma frase que 
 mostre o resultado e se ele  é:
    par ou ímpar;
    positivo ou negativo; 
*/

Console.Write("Digite 2 números (Separados por espaço): ");
string? input = Console.ReadLine();

Console.Write("Digite a conta que deseja fazer. (*, /, +, -): ");
string? conta = Console.ReadLine();

if (input is not null) {
    string[] numeros = input.Split(' ');
    double num1 = double.Parse(numeros[0]);
    double num2 = double.Parse(numeros[1]);
    double resultado, parImpar;
    bool posNeg;

    if (conta == "+") {
        resultado = num1 + num2;
        parImpar = resultado % 2;
        posNeg = resultado > 0;
        Console.WriteLine($"O resultado da operação é {resultado}.");
        if (parImpar == 0) {
            Console.WriteLine($"O número é par.");
        } else if (parImpar == 1) {
            Console.WriteLine($"O número é impar.");
        };
        if (posNeg == true) {
            Console.WriteLine($"O número é positivo.");
        } else if (posNeg == false) {
            Console.WriteLine($"O número é negativo.");
        };
    } else if (conta == "-") {
        resultado = num1 - num2;
        parImpar = resultado % 2;
        posNeg = resultado > 0;
        Console.WriteLine($"O resultado da operação é {resultado}.");
        if (parImpar == 0) {
            Console.WriteLine($"O número é par.");
        } else if (parImpar == 1) {
            Console.WriteLine($"O número é impar.");
        };
        if (posNeg == true) {
            Console.WriteLine($"O número é positivo.");
        } else if (posNeg == false) {
            Console.WriteLine($"O número é negativo.");
        };
    } else if (conta == "*") {
        resultado = num1 * num2;
        parImpar = resultado % 2;
        posNeg = resultado > 0;
        Console.WriteLine($"O resultado da operação é {resultado}.");
        if (parImpar == 0) {
            Console.WriteLine($"O número é par.");
        } else if (parImpar == 1) {
            Console.WriteLine($"O número é impar.");
        };
        if (posNeg == true) {
            Console.WriteLine($"O número é positivo.");
        } else if (posNeg == false) {
            Console.WriteLine($"O número é negativo.");
        };
    } else if (conta == "/") {
        resultado = num1 / num2;
        parImpar = resultado % 2;
        posNeg = resultado > 0;
        Console.WriteLine($"O resultado da operação é {resultado}.");
        if (parImpar == 0) {
            Console.WriteLine($"O número é par.");
        } else if (parImpar == 1) {
            Console.WriteLine($"O número é impar.");
        };
        if (posNeg == true) {
            Console.WriteLine($"O número é positivo.");
        } else if (posNeg == false) {
            Console.WriteLine($"O número é negativo.");
        };
    };
};
