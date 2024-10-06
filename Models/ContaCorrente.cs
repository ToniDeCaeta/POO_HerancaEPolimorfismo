namespace TreinandoPOO.Models;

public class ContaCorrente
{
    public ContaCorrente(int numeroConta, decimal saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public int NumeroConta { get; set; }
    private decimal Saldo { get; set; }


    public void Sacar (decimal valor)
    {
        if(Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
        } 
        else
        {
            Console.WriteLine("Seu saldo é insuficiente para essa transação");
        }

    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Obrigado, seu saldo final é : {Saldo}");
    }

}
