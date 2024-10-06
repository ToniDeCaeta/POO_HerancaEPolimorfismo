namespace TreinandoPOO.Models;

public class Corrente : Conta
{
    public override void Creditar(decimal valor)
    {
        saldo += valor;   // variavel saldo, vem da classe abstrata Conta.
    }
}
