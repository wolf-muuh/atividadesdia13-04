// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga seela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

DateOnly actualDate = DateOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"Digite seu ano de nascimento: ");
int anoNasc = int.Parse(Console.ReadLine());
int anoAtual = actualDate.Year;


comp(anoNasc, anoAtual);

static void comp(int anoNasc, int anoAtual)
{
    if (anoAtual - anoNasc >= 16)
    {
        Console.WriteLine($"Pode votar ;)");

    }
    else if (anoAtual - anoNasc < 16)
    {
        Console.WriteLine($"Não pode votar não :(");

    }
    else
    {
        Console.WriteLine($"Você acabou de nascer o que você ta fazendo aqui???");
    }
}

