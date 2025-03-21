using System;
using System.Collections.Generic;
using System.Linq;

class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
    }

    public int Idade
    {
        get
        {
            DateTime now = DateTime.Now;
            int idade = now.Year - DataNascimento.Year;

            if (now.Month < DataNascimento.Month || (now.Month == DataNascimento.Month && now.Day < DataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }
    }
}

class Instrutor : Pessoa
{
    public string CREF { get; set; }

    public Instrutor(string nome, DateTime dataNascimento, string cpf, string cref) 
        : base(nome, dataNascimento, cpf)
    {
        CREF = cref;
    }
}

class Cliente : Pessoa
{
    public double Altura { get; set; }
    public double Peso { get; set; }

    public Cliente(string nome, DateTime dataNascimento, string cpf, double altura, double peso) 
        : base(nome, dataNascimento, cpf)
    {
        Altura = altura;
        Peso = peso;
    }

    public double CalcularIMC()
    {
        return Peso / (Altura * Altura);
    }
}

class Academia
{
    public List<Instrutor> Instrutores { get; set; }
    public List<Cliente> Clientes { get; set; }

    public Academia()
    {
        Instrutores = new List<Instrutor>();
        Clientes = new List<Cliente>();
    }

    public void AdicionarInstrutor(Instrutor instrutor)
    {
        Instrutores.Add(instrutor);
    }

    public void AdicionarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void MostrarListaInstrutores()
    {
        Console.WriteLine("                     ");
        Console.WriteLine("Lista de Instrutores:");
        foreach (var instrutor in Instrutores)
        {
            Console.WriteLine($"Nome: {instrutor.Nome}, CPF: {instrutor.CPF}, CREF: {instrutor.CREF}");
        }
    }

    public void MostrarListaClientes()
    {
        Console.WriteLine("                  ");
        Console.WriteLine("Lista de Clientes:");
        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Altura: {cliente.Altura}, Peso: {cliente.Peso}");
        }
    }

    public void RelatorioInstrutoresPorIdade(int idadeMinima, int idadeMaxima)
    {
        var instrutoresFiltrados = Instrutores
            .Where(instrutor => instrutor.Idade >= idadeMinima && instrutor.Idade <= idadeMaxima)
            .ToList();

        Console.WriteLine("                                         ");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Instrutores com idade entre {idadeMinima} e {idadeMaxima} anos:");
        foreach (var instrutor in instrutoresFiltrados)
        {
            Console.WriteLine($"Nome: {instrutor.Nome}, Idade: {instrutor.Idade} anos, CREF: {instrutor.CREF}");
        }
    }

    public void RelatorioClientesPorIdade(int idadeMinima, int idadeMaxima)
    {
        var clientesFiltrados = Clientes
            .Where(cliente => cliente.Idade >= idadeMinima && cliente.Idade <= idadeMaxima)
            .ToList();

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Clientes com idade entre {idadeMinima} e {idadeMaxima} anos:");
        foreach (var cliente in clientesFiltrados)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade} anos, CPF: {cliente.CPF}");
        }
    }

   public void RelatorioClientesPorIMC(double imcLimite)
{
    var clientesFiltrados = Clientes
        .Where(cliente => cliente.CalcularIMC() > imcLimite)
        .OrderBy(cliente => cliente.CalcularIMC())
        .ToList();

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Clientes com IMC maior que {imcLimite}, em ordem crescente:");
    foreach (var cliente in clientesFiltrados)
    {
        Console.WriteLine($"Nome: {cliente.Nome}, IMC: {cliente.CalcularIMC():F2}");
    }
}

    public void RelatorioClientesOrdemAlfabetica()
    {
        var clientesOrdenados = Clientes
            .OrderBy(cliente => cliente.Nome)
            .ToList();

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Clientes em ordem alfabética:");
        foreach (var cliente in clientesOrdenados)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}");
        }
    }

    public void RelatorioClientesMaisVelhoParaMaisNovo()
{
    var clientesOrdenados = Clientes
        .OrderBy(cliente => cliente.DataNascimento)
        .ToList();

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Clientes do mais velho para o mais novo:");
    foreach (var cliente in clientesOrdenados)
    {
        Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade} anos, CPF: {cliente.CPF}");
    }
}

    public void RelatorioAniversariantesDoMes(int mes)
    {
        var instrutoresAniversariantes = Instrutores
            .Where(instrutor => instrutor.DataNascimento.Month == mes)
            .ToList();

        var clientesAniversariantes = Clientes
            .Where(cliente => cliente.DataNascimento.Month == mes)
            .ToList();

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Instrutores e Clientes aniversariantes do mês {mes}:");
        
        foreach (var instrutor in instrutoresAniversariantes)
        {
            Console.WriteLine($"Instrutor: {instrutor.Nome}, CPF: {instrutor.CPF}, Data de Nascimento: {instrutor.DataNascimento:dd/MM/yyyy}");
        }

        foreach (var cliente in clientesAniversariantes)
        {
            Console.WriteLine($"Cliente: {cliente.Nome}, CPF: {cliente.CPF}, Data de Nascimento: {cliente.DataNascimento:dd/MM/yyyy}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso:
        Academia academia = new Academia();

        Instrutor instrutor1 = new Instrutor("João", new DateTime(1980, 5, 15), "12345678901", "ABC123");
        Instrutor instrutor2 = new Instrutor("Maria", new DateTime(1990, 8, 25), "98765432109", "XYZ456");

        Cliente cliente1 = new Cliente("Carlos", new DateTime(1995, 5, 10), "11122233344", 1.75, 70.5);
        Cliente cliente2 = new Cliente("Ana", new DateTime(1988, 11, 20), "55566677788", 1.65, 160.0);

        academia.AdicionarInstrutor(instrutor1);
        academia.AdicionarInstrutor(instrutor2);

        academia.AdicionarCliente(cliente1);
        academia.AdicionarCliente(cliente2);

        academia.MostrarListaInstrutores();
        academia.MostrarListaClientes();

        academia.RelatorioInstrutoresPorIdade(25, 40);
        academia.RelatorioClientesPorIdade(20, 30);
        academia.RelatorioClientesPorIMC(25.0);
        academia.RelatorioClientesOrdemAlfabetica();
        academia.RelatorioClientesMaisVelhoParaMaisNovo();
        academia.RelatorioAniversariantesDoMes(5);
    }
}