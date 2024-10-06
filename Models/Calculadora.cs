using TreinandoPOO.Interfaces;

namespace TreinandoPOO;

public class Calculadora : ICalculadora
{
    // o metodo dividir, nao está presente, pois, implementando um corpo na interface, o método não se torna obrigatorio

    public int Multiplicar(int num1, int num2)
    {
        return num1*num2;    }

    public int somar(int num1, int num2)
    {
        return num1+num2;
    }

    public int subtrair(int num1, int num2)
    {
        return num1-num2;
    }
}
