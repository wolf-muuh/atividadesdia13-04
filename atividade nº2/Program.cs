// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool: até 20 litros, desconto de 3% por litro Álcool acima de 20 litros, desconto de 5% por litro
// Gasolina: até 20 litros, desconto de 4% por litro Gasolina acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90. Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine(@$"
-------------------------------------------------------
|                                                     |
|         Preço da gasolina = 5,30 o litro            |
| Digite G para escolher encher o tanque com gasolina |
|         Preço do alcool = 4,90 o litro              |
| Digite A para escolher encher o tanque com gasolina |
|                                                     |
-------------------------------------------------------

");

char opcao = char.Parse(Console.ReadLine());




while (opcao != 'G' && opcao != 'g' && opcao != 'A' && opcao != 'a')
{
    
}
if (opcao == 'G' || opcao == 'g'){
    Console.WriteLine($"Digite quantos litros de gasolina deseja: ");
    float litrosGas = float.Parse(Console.ReadLine());
}
else if (opcao == 'A' && opcao == 'a') {
    Console.WriteLine($"Digite quantos litros de álcool: ");
    float litrosAlcool = float.Parse(Console.ReadLine());
}