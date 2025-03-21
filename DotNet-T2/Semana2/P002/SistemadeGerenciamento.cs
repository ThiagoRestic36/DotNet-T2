// See https://aka.ms/new-console-template for more information
class TarefaPersonalizada
{
    public string NomeTarefa { get; set; }
    public string DescricaoTarefa { get; set; }
    public DateTime Prazo { get; set; }
    public bool Concluida { get; set; }
}

class GerenciadorTarefasPersonalizadas
{
    static List<TarefaPersonalizada> tarefasPersonalizadas = new List<TarefaPersonalizada>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Criar uma nova tarefa personalizada");
            Console.WriteLine("2 - Listar todas as tarefas personalizadas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("4 - Mostrar tarefas pendentes");
            Console.WriteLine("5 - Mostrar tarefas concluídas");
            Console.WriteLine("6 - Excluir tarefa personalizada");
            Console.WriteLine("7 - Pesquisar tarefas personalizadas");
            Console.WriteLine("8 - Mostrar estatísticas de tarefas personalizadas");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarTarefaPersonalizada();
                    break;
                case 2:
                    ListarTarefasPersonalizadas();
                    break;
                case 3:
                    ConcluirTarefaPersonalizada();
                    break;
                case 4:
                    ListarTarefasPendentes();
                    break;
                case 5:
                    ListarTarefasConcluidas();
                    break;
                case 6:
                    ExcluirTarefaPersonalizada();
                    break;
                case 7:
                    PesquisarTarefasPersonalizadas();
                    break;
                case 8:
                    MostrarEstatisticasTarefasPersonalizadas();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CriarTarefaPersonalizada()
    {
        Console.WriteLine("Digite o nome da tarefa personalizada:");
        string nomeTarefa = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa personalizada:");
        string descricaoTarefa = Console.ReadLine();

        Console.WriteLine("Digite o prazo para a tarefa personalizada (dd/mm/aaaa):");
        DateTime prazo = DateTime.Parse(Console.ReadLine());

        TarefaPersonalizada tarefaPersonalizada = new TarefaPersonalizada();
        tarefaPersonalizada.NomeTarefa = nomeTarefa;
        tarefaPersonalizada.DescricaoTarefa = descricaoTarefa;
        tarefaPersonalizada.Prazo = prazo;
        tarefaPersonalizada.Concluida = false;

        tarefasPersonalizadas.Add(tarefaPersonalizada);

        Console.WriteLine("Tarefa personalizada criada com sucesso!");
    }

    static void ListarTarefasPersonalizadas()
    {
        Console.WriteLine("Lista de tarefas personalizadas:");

        for (int i = 0; i < tarefasPersonalizadas.Count; i++)
        {
            Console.WriteLine("{0} - {1} ({2})", i, tarefasPersonalizadas[i].NomeTarefa, tarefasPersonalizadas[i].Prazo.ToString("dd/MM/yyyy"));
        }
    }

    static void ConcluirTarefaPersonalizada()
    {
        Console.WriteLine("Digite o índice da tarefa personalizada concluída:");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < tarefasPersonalizadas.Count)
        {
            tarefasPersonalizadas[indice].Concluida = true;
            Console.WriteLine("Tarefa personalizada marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    static void ListarTarefasPendentes()
    {
        Console.WriteLine("Lista de tarefas personalizadas pendentes:");

        for (int i = 0; i < tarefasPersonalizadas.Count; i++)
        {
            if (!tarefasPersonalizadas[i].Concluida)
            {
                Console.WriteLine("{0} - {1} ({2})", i, tarefasPersonalizadas[i].NomeTarefa, tarefasPersonalizadas[i].Prazo.ToString("dd/MM/yyyy"));
            }
        }
    }

    static void ListarTarefasConcluidas()
    {
        Console.WriteLine("Lista de tarefas personalizadas concluídas:");

        for (int i = 0; i < tarefasPersonalizadas.Count; i++)
        {
            if (tarefasPersonalizadas[i].Concluida)
            {
                Console.WriteLine("{0} - {1} ({2})", i, tarefasPersonalizadas[i].NomeTarefa, tarefasPersonalizadas[i].Prazo.ToString("dd/MM/yyyy"));
            }
        }
    }

    static void ExcluirTarefaPersonalizada()
    {
        Console.WriteLine("Digite o índice da tarefa personalizada a ser excluída:");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < tarefasPersonalizadas.Count)
        {
            tarefasPersonalizadas.RemoveAt(indice);
            Console.WriteLine("Tarefa personalizada excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    static void PesquisarTarefasPersonalizadas()
    {
        Console.WriteLine("Digite a palavra-chave:");
        string palavraChave = Console.ReadLine();

        Console.WriteLine("Resultado da pesquisa:");

        for (int i = 0; i < tarefasPersonalizadas.Count; i++)
        {
            if (tarefasPersonalizadas[i].NomeTarefa.Contains(palavraChave) || tarefasPersonalizadas[i].DescricaoTarefa.Contains(palavraChave))
            {
                Console.WriteLine("{0} - {1} ({2})", i, tarefasPersonalizadas[i].NomeTarefa, tarefasPersonalizadas[i].Prazo.ToString("dd/MM/yyyy"));
            }
        }
    }

    static void MostrarEstatisticasTarefasPersonalizadas()
    {
        int tarefasPendentes = 0;
        int tarefasConcluidas = 0;
        DateTime tarefaMaisAntiga = DateTime.MaxValue;
        DateTime tarefaMaisRecente = DateTime.MinValue;

        for (int i = 0; i < tarefasPersonalizadas.Count; i++)
        {
            if (tarefasPersonalizadas[i].Concluida)
            {
                tarefasConcluidas++;
            }
            else
            {
                tarefasPendentes++;
            }

            if (tarefasPersonalizadas[i].Prazo < tarefaMaisAntiga)
            {
                tarefaMaisAntiga = tarefasPersonalizadas[i].Prazo;
            }

            if (tarefasPersonalizadas[i].Prazo > tarefaMaisRecente)
            {
                tarefaMaisRecente = tarefasPersonalizadas[i].Prazo;
            }
        }

        Console.WriteLine("Estatísticas:");
        Console.WriteLine("Tarefas personalizadas pendentes: {0}", tarefasPendentes);
        Console.WriteLine("Tarefas personalizadas concluídas: {0}", tarefasConcluidas);
        Console.WriteLine("Tarefa personalizada mais antiga: {0}", tarefaMaisAntiga.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tarefa personalizada mais recente: {0}", tarefaMaisRecente.ToString("dd/MM/yyyy"));
    }
}