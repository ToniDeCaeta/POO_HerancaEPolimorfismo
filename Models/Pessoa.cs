namespace TreinandoPOO.Models;

public class Pessoa
{
    public Pessoa() //Construtor vazio, para dar a opção de instanciar manualmente. 
    {

    }

    public Pessoa(string nome) //criando construtor na classe abstrata. 
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }


    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos de idade");
    }

}
