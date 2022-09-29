Console.WriteLine("Perguntas Da Bíblia \n");

int homens = 0;
int mulheres = 0;

Console.WriteLine("Qual menino na Bíblia quase foi morto pelo pai?\n");

Console.WriteLine("Quem vai responder essa rodada?\n\nDigite 1 para homens e 2 para mulheres");
int escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("\nA. Abraão\nB. Davi\nC. Isaque\nD. José\nE. Salomão\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "C" || letra == "c")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para os homens");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para as mulhres!");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
}
else if (escolha == 2)
{
    Console.WriteLine("\nA. Abraão\nB. Davi\nC. Isaque\nD. José\nE. Salomão\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "C" || letra == "c")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para as mulheres");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para os homens!");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
}

Console.WriteLine("Quem escreveu os Provérbios?\n");

Console.WriteLine("Quem vai responder essa rodada?\n\nDigite 1 para homens e 2 para mulheres");
escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("\nA. Davi\nB. Salomão\nC. Moises\nD. Jocó\nE. Daniel\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "B" || letra == "b")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para os homens");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para as mulhres!");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
}
else if (escolha == 2)
{
    Console.WriteLine("\nA. Davi\nB. Salomão\nC. Moises\nD. Jocó\nE. Daniel\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "B" || letra == "b")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para as mulheres");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para os homens!");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
}

Console.WriteLine("Em qual livro a Bíblia fala de Sansão?\n");

Console.WriteLine("Quem vai responder essa rodada?\n\nDigite 1 para homens e 2 para mulheres");
escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("\nA. Salmos\nB. 1Reis\nC. 2Samuel\nD. 2Reis\nE. Juízes\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "E" || letra == "e")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para os homens");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para as mulhres!");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
}
else if (escolha == 2)
{
    Console.WriteLine("\nA. Salmos\nB. 1Reis\nC. 2Samuel\nD. 2Reis\nE. Juízes\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "E" || letra == "e")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para as mulheres");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para os homens!");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
}

Console.WriteLine("Miguel lutou com um…?\n");

Console.WriteLine("Quem vai responder essa rodada?\n\nDigite 1 para homens e 2 para mulheres");
escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    Console.WriteLine("\nA. Dragão\nB. Anjo\nC. Humano\nD. Animal\nE. Dinossauro\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "A" || letra == "a")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para os homens");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para as mulhres!");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
}
else if (escolha == 2)
{
    Console.WriteLine("\nA. Dragão\nB. Anjo\nC. Humano\nD. Animal\nE. Dinossauro\n\nDigite a sua respotasta?");
    string letra = Console.ReadLine();

    if (letra == "A" || letra == "a")
    {
        Console.WriteLine("\nCerta resposta!\n\nPonto para as mulheres");

        mulheres++;

        Console.WriteLine("\nA pontuação das mulheres é de: " + mulheres + " ponto\n");
    }
    else
    {
        Console.WriteLine("\nErrada Resposta!\n\nPonto para os homens!");

        homens++;

        Console.WriteLine("\nA pontuação dos homens é de: " + homens + " ponto\n");
    }
}

if (homens > mulheres)
{
    Console.WriteLine("\nHomens Ganharam!");
}
else if (mulheres > homens)
{
    Console.WriteLine("\nMulheres Ganharam!");
}
else
{
    Console.WriteLine("\nEmpate!");
}