﻿// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Tabuada do {0}:", i);


    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
    }

    Console.WriteLine();
}