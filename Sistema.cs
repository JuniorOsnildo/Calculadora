namespace Calculadora;

public class Sistema
{
    public static void Somar(float numero1, float numero2)
    {
        float resultado = numero1 + numero2;
        Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
    }
    public static void Sub(float numero1, float numero2)
    {
        float resultado = numero1 - numero2;
        Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
    }
    public static void Mult(float numero1, float numero2)
    {
        float resultado = numero1 * numero2;
        Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
    }
    public static void Div(float numero1, float numero2)
    {
        float resultado = numero1 / numero2;
        Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
    }
    
}