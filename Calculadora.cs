// 1 - Namespace = Conjunto de Classe
namespace Calculadora;

// 2 - Bibliotecas = Conjunto de funções prontas


// 3 - Classe = Entidade que vamos criar (nosso programa)
public class Calculadora
{

    // 3.1 - Atributos = Características / Campos


    // 3.2 - Funções e Métodos
    public int somarDoisNumeros(int num1, int num2)
    {
        int resultado = num1 + num2;
        //  resultado = 1    +     2
        //  resultado = 3
        return num1 + num2;

    } // fim da função somarDoisNumeros

    public int subtrairDoisNumeros(int num1, int num2)
    {
        return num1 - num2;
    } // fim da função subtrairDoisNumeros

    public int multiplicarDoisNumeros(int num1, int num2)
    {
        return num1 * num2;
    } // fim da função multiplicarDoisNumeros

    public int dividirDoisNumeros(int num1, int num2)
    {
        return num1 / num2;
    } // fim da função dividirDoisNumeros

} // fim da classe
