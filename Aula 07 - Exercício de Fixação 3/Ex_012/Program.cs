Console.Write("Digite um valor de 1 a 7: ");
byte input = byte.Parse(Console.ReadLine());

switch (input) {
    case 1: 
        Console.WriteLine("Domingo");
        break;
    case 2: 
        Console.WriteLine("Segunda-Feira");
        break;
    case 3: 
        Console.WriteLine("Terça-Feira");
        break;
    case 4: 
        Console.WriteLine("Quarta-Feira");
        break;
    case 5: 
        Console.WriteLine("Quinta-Feira");
        break;
    case 6: 
        Console.WriteLine("Sexta-Feira");
        break;
    case 7: 
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Valor Inválido!");
        break;
};
