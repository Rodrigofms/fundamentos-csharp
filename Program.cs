using FundamentosCs.Models;

//Uso de Classes e Funções Matematicas

Pessoa pessoa1 = new()
{
    Nome = "Bob",
    Idade = 20,
    TipoSanguineo = "AB",
    FatorRH = '+'
};

Pessoa pessoa2 = new()
{
    Nome = "Ariel",
    Idade = 5000,
    TipoSanguineo = "O",
    FatorRH = '-'
};

Calculadora calcular = new();

pessoa1.Apresentar();
pessoa2.Apresentar();
Console.WriteLine("");
calcular.Somar(2, 5);
calcular.Subtrair(55, 8);
calcular.Multiplicar(85, 990);
calcular.Dividir(550, 20);
calcular.Potencia(5, 2);
calcular.RaizQuadrada(144);
calcular.Seno(45);
calcular.Coseno(75);
calcular.Tangente(30);
Console.WriteLine("");

//Estudo do uso do DateTime e .ToString

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM HH:mm"));
Console.WriteLine("");


// Uso do For 

Console.WriteLine("Digite a tabuada que quer saber: ");
int tabuada = Convert.ToInt32(Console.ReadLine());

for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
{
    Console.WriteLine($"{tabuada} x {multiplicador} = {tabuada * multiplicador}");
}
Console.WriteLine("");

//Uso do While

Console.WriteLine("Digite a tabuada que quer saber: ");
string tabuada1 = Console.ReadLine();
Console.WriteLine("");
int inputToInt;
int.TryParse(tabuada1, out inputToInt);

int multiplicador1 = 0;

while (multiplicador1 <= 10)
{
    Console.WriteLine($"{inputToInt} x {multiplicador1} = {inputToInt * multiplicador1}");
    multiplicador1++;
}
Console.WriteLine("");

/*string opcao;

while (true)
{
    Console.WriteLine("1. Cadastrar Clientes");
    Console.WriteLine("2. Buscar Clientes");
    Console.WriteLine("3. Apagar Clientes");
    Console.WriteLine("0. Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {

        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Clientes");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            Environment.ExitCode(0);
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }
} */

//Uso do Do-While

int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um numero para somar (0 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
} while (numero != 0);

Console.WriteLine($"Total da soma foi de {soma}");


//Estudo de arrays com For

int[] arrayInteiros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int n = 0; n < arrayInteiros.Length; n++)
{
    Console.WriteLine($"No index {n}, o numero equivalente - {arrayInteiros[n]}");
}

//.resize ajusta o valor de array
//.copy autoexplicativo

//Estudo de arrays com Foreach

foreach (int n in arrayInteiros)
{
    Console.WriteLine($"{n}");
}

//Estudo de lista

List<string> listadenomes = new()
{
    "SP", "RJ", "PE", "SC"
};

//Estudo de lista com For

for (int contador = 0; contador < listadenomes.Count; contador++)
{
    Console.WriteLine($"Posicao {contador} {listadenomes[contador]}");
}

//Estudo de lista com Foreach

foreach (string x in listadenomes)
{
    Console.WriteLine(x);
}