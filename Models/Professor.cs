namespace TreinandoPOO.Models;

public class Professor : Pessoa
{
    public Professor () //Construtor vazio
    {

    }

    public Professor(string nome) : base (nome) 
    {
        //esse construtor, é obrigatorio, pois a classe abstrata pessoa possui uma, exigindo string nome.
    }


    public decimal Salario { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salario atual é: R$ {Salario}");
    }
}
