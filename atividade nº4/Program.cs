// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

int[] numeros = new int[10];

Console.WriteLine($"Digite 10 números");

for (int i = 0; i < numeros.Length; i++)
{
   Console.WriteLine($"{i+1}º número:");
   numeros[i] = int.Parse(Console.ReadLine()); 
}

Console.WriteLine(@$"
maior número: {numeros.Max()}
menor número: {numeros.Min()}
");
