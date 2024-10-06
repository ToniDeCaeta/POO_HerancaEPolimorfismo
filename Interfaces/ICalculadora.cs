namespace TreinandoPOO.Interfaces;

public interface ICalculadora
{
    int somar(int num1, int num2);
    int subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);


    int Dividir(int num1, int num2) // metodo com corpo, não é obrigatorio a implementação na classe destino. 
    {
        return num1/num2;
    }
}
