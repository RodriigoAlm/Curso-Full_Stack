int[] numeros = new int[10];

for (int i = 0; i < 10; i++) {
    Console.Write("Digite 10 números: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
 Console.WriteLine("\nOrdem Inversa: ");

 for (int i = 9; i >= 0; i--) {
    Console.Write(($"{numeros[i]} "));
 }
