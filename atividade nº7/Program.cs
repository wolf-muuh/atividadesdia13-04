﻿// - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi declarado.
int[] numeros = new int[15];

for (int i = 0; i < 15; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Olha o reverse:");
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}