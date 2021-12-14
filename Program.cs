using CadastroSeries;

class Program
{
    static SerieRepositorio repositorio = new SerieRepositorio();
    
    static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();

        while (opcaoUsuario != "X")
        {
             switch (opcaoUsuario)
             {
                 case "1": 
                    ListarSeries();
                    break;
                 case "2": 
                    InserirSerie();
                    break;
                 case "3": 
                    AtualizarSerie();
                    break;
                 case "4": 
                    ExcluirSerie();
                    break;
                 case "5": 
                    VisualizarSerie();
                    break;
                 case "C": 
                    Console.Clear();
                    break;
                 
                 default:
                    Console.WriteLine("Opção inválida");
                    break;
             }
             opcaoUsuario = ObterOpcaoUsuario();
        }

        Console.WriteLine("Obrigado por utilizar nossos serviços.");
		Console.ReadLine();
    }
    //opcao 1

    private static void ListarSeries()
    {
        Console.WriteLine("Listar Séries");
        var lista = repositorio.Listar();
        
        if (lista.Count() == 0)
        {
            Console.WriteLine("Nenhuma série encontrada.");
            return;
        }
        
        
        foreach (var serie in lista)
        {
            var excluido = serie.RetornarExcluido();
            Console.WriteLine("#ID {0}: - {1} - {2}", serie.RetornarId(), serie.RetornarTitulo(), (excluido ? "Indisponível" : "Disponível"));
        }
    }

    //Opcao 2
    private static void InserirSerie()
    {
        Console.WriteLine("Inserir nova série");
        foreach(int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }

        Console.WriteLine("Digite o genêro entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano da série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o titulo da Série: ");
        string entradaTitulo = Console.ReadLine();

        Console.WriteLine("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);
        
        repositorio.Inserir(novaSerie);                                                                 

    }

    //opção 3 - AtualizarSerie
    private static void AtualizarSerie()
    {
        Console.WriteLine("Digite o ID da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        foreach(int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }

        Console.WriteLine("Digite o genêro entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano da série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o titulo da Série: ");
        string entradaTitulo = Console.ReadLine();

        Console.WriteLine("Digite a Descrição da Série: ");
        string entradaDescricao = Console.ReadLine();

        Serie atualizaSerie = new Serie(id: indiceSerie,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);
        
        repositorio.Atualizar(indiceSerie, atualizaSerie);                             

        
    }
    //opção 4 - ExcuirSerie
    private static void ExcluirSerie()
    {
        Console.WriteLine("Para excluir, digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        repositorio.Excluir(indiceSerie);
    }

    //opção 5 - VisualizarSerie
    private static void VisualizarSerie()
    {
        Console.WriteLine("Para Visualizar digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());
        
        var serie = repositorio.RetornarPorId(indiceSerie);

        Console.WriteLine(serie);


    }

    //opções do usuário
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO Séries a seu dispor!!!!");
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1 - Listar série");
        Console.WriteLine("2 - Inserir nova série");
        Console.WriteLine("3 - Atualizar série");
        Console.WriteLine("4 - Excluir série");
        Console.WriteLine("5 - Visualizar série");
        Console.WriteLine("C - Limpar Tela");
        Console.WriteLine("X - Sair");
        
        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();

        return opcaoUsuario;
    }


}