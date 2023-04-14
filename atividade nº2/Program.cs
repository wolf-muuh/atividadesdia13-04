// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool: até 20 litros, desconto de 3% por litro Álcool acima de 20 litros, desconto de 5% por litro
// Gasolina: até 20 litros, desconto de 4% por litro Gasolina acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90. Dica: utilize switch case e funções/métodos para otimizar o algorítimo.]


// Criar função para calcular gasolina
// Criar função para calcular alcool
// Criar switch case e comparar o combustivel selecionado. Ao depender da opção chamar a função para calculo do valor.

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

switch (opcao)
{
    case 'G':
        Console.WriteLine($"Digite quantos litros de gasolina você quer:");
        float lGas = float.Parse(Console.ReadLine());

        Console.WriteLine($"O preço que você vai pagar é: {sla(lGas)}");



        break;
    case 'A':
        Console.WriteLine($"Digite quantos litros de álcool você deseja: ");
        float lAlcool = float.Parse(Console.ReadLine());
        Console.WriteLine($"O preço que você vai pagar é: {scrr(lAlcool)}");


        break;
    default:
        Console.WriteLine($"Digite novamente, se escreveu em minusculo as letras digite em maiusculo o programador esta com preguiça");
        break;
}

static float sla(float lGas)
{
    if (lGas <= 20)
    {
        return (float)(lGas * 5.30 - lGas * 3 / 100);
    }
    else
    {
        return (float)(lGas * 5.30 - lGas * 5 / 100);
    }
}

static float scrr(float lAlcool){
    if (lAlcool <= 20)
    {
        return (float)(lAlcool * 4.90 - lAlcool * 4 / 100);
    }
    else
    {
        return (float)(lAlcool * 4.90 - lAlcool * 6 / 100);
    }
}







