namespace TreinandoPOO.Models;

public class Aluno : Pessoa
{
    public Aluno()
    {
        //COnstrutor vazio
    }
    public Aluno(string nome) : base (nome)
    {
        // construtor obrigatorio, pois herdou da classe abstrata um contrutor.
    }

    public double Nota { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
    }
}
