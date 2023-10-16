// 1 - Namespace = Conjunto de Classe
namespace Calculadora;

// 2 - Bibliotecas = Conjunto de funções prontas


// 3 - Classe = Entidade que vamos criar (nosso programa)
public class Calculadora
{

    // 3.1 - Atributos = Características / Campos


    // 3.2 - Funções e Métodos
    public static int somarDoisNumeros(int num1, int num2)
    {
        int resultado = num1 + num2;
        //  resultado = 1    +     2
        //  resultado = 3
        return num1 + num2;

    } // fim da função somarDoisNumeros

    public static int subtrairDoisNumeros(int num1, int num2)
    {
        return num1 - num2;
    } // fim da função subtrairDoisNumeros

    public static int multiplicarDoisNumeros(int num1, int num2)
    {
        return num1 * num2;
    } // fim da função multiplicarDoisNumeros

    public static int dividirDoisNumeros(int num1, int num2)
    {
        return num1 / num2;
    } // fim da função dividirDoisNumeros

    public  static void Main()
    {
        // chamar as 4 operações
        Console.WriteLine("5 + 7 = " + somarDoisNumeros(5,7));
        Console.WriteLine("5 - 7 = " + subtrairDoisNumeros(5,7));
        Console.WriteLine("5 * 7 = " + multiplicarDoisNumeros(5,7));
        Console.WriteLine("35 / 7 = " + dividirDoisNumeros(35,7));

    }


} // fim da classe
