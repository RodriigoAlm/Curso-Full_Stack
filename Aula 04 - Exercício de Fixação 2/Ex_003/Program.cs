﻿Console.Write("Digite a metragem a ser convertida: ");

int valor_digitado = int.Parse (Console.ReadLine());

Console.WriteLine($"Valor em centímetros: {valor_digitado * 100}cm");
//Caso seja um valor , usar a ","