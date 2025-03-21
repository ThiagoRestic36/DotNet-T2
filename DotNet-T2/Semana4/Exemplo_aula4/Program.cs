using System;
/*
#region Questao 01
public class Veiculo
{
    // Propriedades
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }

    // Construtor
    public Veiculo(string modelo, int ano, string cor)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }

    // Método para exibir informações do veículo
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
    }
}

class Program
{
    static void Main()
    {
    
        Veiculo meuCarro = new Veiculo("Carro XYZ", 2022, "Azul");

        
        Console.WriteLine("Informações do Veículo:");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Modelo: {meuCarro.Modelo}");
        Console.WriteLine($"Ano: {meuCarro.Ano}");
        Console.WriteLine($"Cor: {meuCarro.Cor}");

        
        Console.ReadKey();
    }
}
#endregion*/
/*
#region Questao 02

public class Veiculo
{
    // Propriedades
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }

    // Propriedade somente leitura para calcular a idade do veículo
    public int IdadeVeiculo
    {
        get
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }
    }

    // Construtor
    public Veiculo(string modelo, int ano, string cor)
    {
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }

    // Método para exibir informações do veículo
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Idade do Veículo: {IdadeVeiculo} anos");
    }
}

class Program
{
    static void Main()
    {
        // Criar uma instância da classe Veiculo
        Veiculo meuCarro = new Veiculo("Carro XYZ", 2022, "Azul");

        // Exibir informações do veículo no console
        Console.WriteLine("Informações do Veículo:");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Modelo: {meuCarro.Modelo}");
        Console.WriteLine($"Ano: {meuCarro.Ano}");
        Console.WriteLine($"Cor: {meuCarro.Cor}");
        Console.WriteLine($"Idade do Veículo: {meuCarro.IdadeVeiculo} anos");

        // Aguardar pressionamento de tecla antes de fechar o console
        Console.ReadKey();
    }
}

#endregion*/

/*
#region Questao 03

public class ContaBancaria
{
    private decimal _saldo;

    public decimal Saldo
    {
        get { return _saldo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Saldo não pode ser negativo");
            }
            _saldo = value;
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria minhaConta = new ContaBancaria();

        
        try
        {
            minhaConta.Saldo = 100;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        
        Console.WriteLine($"Saldo Atual: {minhaConta.Saldo}");
    }
}

#endregion*/

#region Questao 04


#endregion