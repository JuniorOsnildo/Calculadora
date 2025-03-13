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
        Console.WriteLine("5 - Sair");
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
        float primeiroValor = ColetarDados();
        float segundoValor = ColetarDados();

        switch (opcao)
        {
            case 1: Sistema.Somar(primeiroValor, segundoValor); break;
            case 2: Sistema.Sub(primeiroValor, segundoValor); break;
            case 3: Sistema.Mult(primeiroValor, segundoValor); break;
            case 4: Sistema.Div(primeiroValor, segundoValor); break;
            default: Console.WriteLine("Valor invalido!"); break;
        }
        Console.ReadKey();
    }
}