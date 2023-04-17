// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
string[] nomes = new string[10];


for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
    nomes[i] = Console.ReadLine();
}

Console.Write("Digite o nome para busca: ");
string nomeBusca = Console.ReadLine();

bool encontrou = false;
for (int i = 0; i < nomes.Length; i++)
{
    if (nomes[i] == nomeBusca)
    {
        encontrou = true;
        break;
    }
}

if (encontrou)
{
    Console.WriteLine("ACHEI");
}
else
{
    Console.WriteLine("NÃO ACHEI");
}
