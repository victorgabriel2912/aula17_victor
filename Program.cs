// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine ("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine ("Digite a sua data de nascimento no formato dd/mm/yy");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine ("Digite seu CPF sem ponto ou caracter: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("Digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, dataNascimento, cpf, peso, altura);

int Idade = p.CalcularIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while(!sair)
{

    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuário");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar a maioridade do usuário");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

switch(opcao)
{
    case "0":
    Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
    Console.WriteLine($"Data de Nascimento: {dataNascimento}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"CPF: {cpf}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {Idade}");
    break;

    case "1":
    Console.WriteLine($"Seu imc é: {imc}");
        if(imc < 17)
    {
        Console.WriteLine($"Ola {nome}, voce está Muito Abaixo do Peso, por ter {imc} do IMC!");
    }else if(imc <17)
    {
        Console.WriteLine($"Ola {nome}, voce está Abaixo do Peso, por ter {imc} do IMC!");
    }else if(imc >= 17 && imc <19)
    {
        Console.WriteLine($"Ola {nome}, voce está com o Peso Normal, por ter {imc} do IMC!");
    }else if(imc >= 19 && imc <25)
    {
        Console.WriteLine($"Ola {nome}, voce está Acima do Peso, por ter {imc} do IMC!");
    }else if(imc >= 25 && imc <30)
    {
        Console.WriteLine($"Ola {nome}, voce está com Obesidade grau I, por ter {imc} do IMC!");
    }else if(imc >= 30 && imc <35)
    {
        Console.WriteLine($"Ola {nome}, voce está com Obesidade grau II, por ter {imc} do IMC!");
    }else if(imc >= 35 && imc <41)
    {
        Console.WriteLine($"Ola {nome}, voce está com Obesidade grau III, por ter {imc} do IMC!");
    }
    
    break;

    case "2":
    if(Idade >= 18) //se
    {
        Console.WriteLine($"Ola {nome}, parabens voce ja é Maior de idade por ter {Idade} anos de idade");
    }else
    Console.WriteLine($"Ola {nome}, voce é Menor de idade por ter apenas {Idade} anos de idade");
    break;

    case "3":
    sair = true;
    break;

    


}


}



// Console.WriteLine("Hello, World!");

// Pessoa p = new Pessoa();

// p.Nome = "Gomes";
// p.Sobrenome = "Oliveira";
// p.CPF = 12345678;

// Console.WriteLine($"Ola {p.Nome} {p.Sobrenome} seu CPF é {p.CPF}");
