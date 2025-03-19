namespace Calculadora;

public class Menus
{
    public static void MenuOpcao()
    {
        Console.Clear();
        Console.WriteLine("Qual operação você deseja realizar?");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Tabuada");
        Console.WriteLine("6 - Sair");
        Console.WriteLine("0 - histórico");
        Console.Write(" -> ");
    }

    private static float ColetarDados()
    {
        float num = 0;
        
        try
        {
            Console.Clear();
            Console.WriteLine("Digite o valor");
            Console.Write("-> ");

            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        catch
        {
            ColetarDados();
        }
        
        return num;
    }

    public static void Calculos(int opcao)
    {
        float primeiroValor;
        float segundoValor;

        Console.Clear();
        switch (opcao)
        {
            case 1:
                primeiroValor = ColetarDados();
                segundoValor = ColetarDados();
                Sistema.Somar(primeiroValor, segundoValor);
                break;
            case 2:
                primeiroValor = ColetarDados();
                segundoValor = ColetarDados();
                Sistema.Sub(primeiroValor, segundoValor);
                break;
            case 3:
                primeiroValor = ColetarDados();
                segundoValor = ColetarDados();
                Sistema.Mult(primeiroValor, segundoValor);
                break;
            case 4:
                primeiroValor = ColetarDados();
                segundoValor = ColetarDados();
                Sistema.Div(primeiroValor, segundoValor);
                break;
            case 5:
                primeiroValor = ColetarDados();
                Sistema.Tabuada(primeiroValor);
                break;
            case 0:
                Sistema.MostrarHistorico();
                break;
            default:
                Console.WriteLine("Valor invalido!");
                break;
        }
        Console.ReadKey();
    }
}