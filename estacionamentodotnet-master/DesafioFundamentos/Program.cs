using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":

        Console.Clear();
        
        Console.WriteLine("Veículos");
        Console.Write("Número da placa => : ");
        string? placa = Console.ReadLine();

        Console.WriteLine("\nTaxas");
        Console.Write("Valor inicial do Estacionamento: ");
        decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
        
        veiculo.AdicionarVeiculo(placa!, valorInicial);
        Console.Clear();

            es.AdicionarVeiculo(placa!, valorInicial);
            break;

        case "2":
            Console.Clear();
            es.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            es.ListarVeiculos(usuario!);
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
